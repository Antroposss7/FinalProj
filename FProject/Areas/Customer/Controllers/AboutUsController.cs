using FProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FProject.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            var model = new AboutUsViewModel { Message = "Welcome to KAWS BAKU, the premier destination for KAWS enthusiasts and collectors. Our mission is to bring you the finest selection of KAWS artwork and merchandise, fostering a community of collectors who cherish contemporary art and urban culture.\r\n\r\nFounded in 2023, our online store has grown to become a trusted platform for discovering and purchasing authentic KAWS pieces. We are committed to providing not only the best KAWS products but also an exceptional shopping experience. Our team of experts ensures the authenticity of every piece we sell, making [YourWebsiteName] a safe and reliable marketplace for KAWS collectors.\r\n\r\nAt KAWS BAKU, we believe in the power of art to inspire and transform. KAWS, born Brian Donnelly, has left an indelible mark on the contemporary art scene with his iconic characters and thought-provoking artwork. We are honored to share our passion for KAWS’s unique aesthetic and message with collectors worldwide.\r\n\r\nOur online store features an extensive range of KAWS products including limited edition figurines, prints, and apparel. We also provide a platform for KAWS enthusiasts to learn more about the artist, his collaborations, and his impact on the modern art world.\r\n\r\nOur Promise:\r\n\r\nAuthenticity: Every item sold on our platform is thoroughly inspected and verified by our team of experts to ensure its authenticity.\r\nQuality: We pride ourselves on offering only the highest quality products in pristine condition.\r\nCustomer Satisfaction: Your satisfaction is our priority. Our customer service team is dedicated to ensuring a smooth shopping experience and is always available to answer any of your questions.\r\nCommunity & Education:\r\n\r\nWe are not just a store; we are a community of like-minded individuals who appreciate the creativity and uniqueness of KAWS's work. Our blog and social media channels offer insights, news, and discussions about KAWS’s latest releases and the contemporary art scene.\r\n\r\nJoin us in celebrating the extraordinary world of KAWS, where art meets urban culture. Explore our collection today and find that perfect piece that resonates with you.\r\n\r\nThank you for choosing KAWS BAKU. Together, let’s keep the spirit of contemporary art alive and thriving." };
            return View(model);
        }
    }
}