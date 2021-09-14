using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class StatusController : Controller
    {
        
        public readonly ApplicationDbContext _db;
        public IEnumerable<OrderItem> OrderItem { get; set; }

        

        public StatusController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Edit()
        {
            OrderItem = _db.OrderItem.Where(x => x.OrderId == 0).ToList();
            return View(OrderItem);
        }
       [HttpPost]
        public IActionResult Edit(int OrderId)
        {
             OrderItem = _db.OrderItem.Where(x => x.OrderId == OrderId).ToList();
            return View(OrderItem);

            //return OrderId+2;
        }
        public IActionResult Cancel(int Id)  
        {
            List<CancelItems> result = (from items in _db.OrderItem.Where(x => x.ItemId == Id)
                                        join
                                         dates in _db.Delivery.Where(x => x.ItemId == Id)
                                        on
                                        items.ItemId equals dates.ItemId
                                        select new CancelItems
                                        {
                                            OrderId = items.OrderId,
                                            ItemId = items.ItemId,
                                            Amount = items.Amount,
                                            Status = items.Status,
                                            From = dates.From,
                                            To = dates.To,

                                        }
          ).ToList();
            ViewData["operation"] = "Cancel";
            return View(result);

        }
        [HttpGet]
        public IActionResult CancelDetails(int Id)
        {
            var item = _db.OrderItem.FirstOrDefault(x => x.ItemId == Id);
            
            item.Status = "Cancelled";
            _db.SaveChanges();
            ViewData["itemid"] = Id;
            var feedback = _db.FeedBack.FirstOrDefault(x => x.ItemId == 9838);
            return View(feedback);
            //_db.OrderItem.Remove(item);
        }
        [HttpPost]
        public IActionResult CancelDetails(FeedBack feedback)
        {
            _db.FeedBack.Add(feedback);
            _db.SaveChanges();

            return RedirectToAction(nameof(Edit));
        }
        public IActionResult Postpone(int Id)
        {
            List<CancelItems> result = (from items in _db.OrderItem.Where(x => x.ItemId == Id)
                                        join
                                         dates in _db.Delivery.Where(x => x.ItemId == Id)
                                        on
                                        items.ItemId equals dates.ItemId
                                        select new CancelItems
                                        {
                                            OrderId = items.OrderId,
                                            ItemId = items.ItemId,
                                            Amount = items.Amount,
                                            Status = items.Status,
                                            From = dates.From,
                                            To = dates.To,

                                        }
          ).ToList();
            ViewData["operation"] = "Postpone";
            return View(result);

        }
        public IActionResult PostponeandFeedback(int id)
        {
            ViewData["itemId"] = id;
            return View();
        }
        public IActionResult Feedback(PostponeForm data)
        {
            var itemid = data.ItemId;
            var from = data.From;
            var to = data.To;

            var item = _db.Delivery.FirstOrDefault(x => x.ItemId == itemid);
            item.From = from;
            item.To = to;
            _db.SaveChanges();




            
            var reason = data.Reason;
            var rating = data.Rating;

            _db.FeedBack.Add(new FeedBack { ItemId = itemid, Operation = "postponement", Reason = reason, Rating = rating });
            _db.SaveChanges();

            return RedirectToAction(nameof(Edit));
        }
        public IActionResult UserFeedback()
        {
            var result = _db.FeedBack.ToList();
            return View(result);
        }

        //[HttpGet]
        //public IActionResult PostponeForm(int id)
        //{
        //    var form = _db.Delivery.FirstOrDefault(x => x.ItemId == id);
        //    return View(form);

        //}
        //[HttpPut]
        //public IActionResult PostponeForm(Delivery delivery)
        //{
        //    if(ModelState.IsValid)
        //    {

        //        _db.Delivery.Update(delivery);
        //        _db.SaveChanges();

        //        ViewData["itemid"] = delivery.ItemId;
        //        var feedbacks = _db.FeedBack.FirstOrDefault(x => x.ItemId == delivery.ItemId);
        //        return View(feedbacks);

        //    }

        //    return RedirectToPage(nameof(Edit));

        //}





    }
}
