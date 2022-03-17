using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OnlineBookStore.Infrastructure;

namespace OnlineBookStore.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();

            cart.Session = session;

            return cart;
        }

        [JsonIgnore] //prevents a property from being serialized or de-serialized
        public ISession Session { get; set; }

        public override void AddItem(Book bookItem, int qty)
        {
            base.AddItem(bookItem, qty);
            Session.SetJson("Cart", this);
        }

        public override void RemoveItem(Book bookItem)
        {
            base.RemoveItem(bookItem);
            Session.SetJson("Cart", this);
        }

        public override void ClearCart()
        {
            base.ClearCart();
            Session.Remove("Cart");
        }
    }
}
