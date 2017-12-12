using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BethanyPieShop.Models
{
    public class ShoppingCart
    {
        private AppDbContext _appDbContext;

        private ShoppingCart(AppDbContext context)
        {
            _appDbContext = context;
        }

        public string ShoppingCartId { get; set; }

        public IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            var context = services.GetService<AppDbContext>();
            return new ShoppingCart(context) { ShoppingCartId = cartId };

            //return new ShoppingCart(_appDbContext) {ShoppingCartId = cartId};
        }

        public void AddToCart(Pie pie, int amount)
        {
            
        }
    }
}
