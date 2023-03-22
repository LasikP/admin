using Microsoft.AspNetCore.Mvc;
using Ski_Rental.Models;
using System.Data.Entity;

namespace Ski_Rental.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            
                var narty = db.Narty.ToList();
                var buty = db.ButyNarciarskie.ToList();


                ViewBag.Narty = narty;
                ViewBag.Buty = buty;
            
           
            return View();


        }

        [HttpPost]

        public ActionResult Rezerwacja(int id, string typSprzetu, DateTime dataOdbioru, DateTime dataZwrotu)
        {
            if (typSprzetu == "narty")
            {
                var narty = db.Narty.Find(id);
                if (narty.Dostepnosc == false)
                {
                    ViewBag.ErrorMessage = "Narty niedostępne w wybranym terminie.";
                    return RedirectToAction("Index");
                }
                else
                {
                    narty.Dostepnosc = false;
                    db.Entry(narty).State = EntityState.Modified;

                    Rezerwacja rezerwacja = new Rezerwacja();
                    rezerwacja.SprzetID = id;
                    rezerwacja.TypSprzetu = "narty";
                    rezerwacja.DataOdbioru = dataOdbioru;
                    rezerwacja.DataZwrotu = dataZwrotu;

                    db.Rezerwacje.Add(rezerwacja);
                    db.SaveChanges();

                    ViewBag.SuccessMessage = "Rezerwacja nart zakończona pomyślnie.";
                    return RedirectToAction("Index");
                }
            }
            else if (typSprzetu == "buty")
            {
                var buty = db.ButyNarciarskie.Find(id);
                if (buty.Dostepnosc == false)
                {
                    ViewBag.ErrorMessage = "Buty niedostępne w wybranym terminie.";
                    return RedirectToAction("Index");
                }
                else
                {
                    buty.Dostepnosc = false;
                    db.Entry(buty).State = EntityState.Modified;

                    Rezerwacja rezerwacja = new Rezerwacja();
                    rezerwacja.SprzetID = id;
                    rezerwacja.TypSprzetu = "narty";
                    rezerwacja.DataOdbioru = dataOdbioru;
                    rezerwacja.DataZwrotu = dataZwrotu;

                    db.Rezerwacje.Add(rezerwacja);
                    db.SaveChanges();

                    ViewBag.SuccessMessage = "Rezerwacja nart zakończona pomyślnie.";
                    return RedirectToAction("Index");
                }
            }
            else if (typSprzetu == "buty")
            {
                var buty = db.ButyNarciarskie.Find(id);
                if (buty.Dostepnosc == false)
                {
                    ViewBag.ErrorMessage = "Buty niedostępne w wybranym terminie.";
                    return RedirectToAction("Index");
                }
                else
                {
                    buty.Dostepnosc = false;
                    db.Entry(buty).State = EntityState.Modified;

                    Rezerwacja rezerwacja = new Rezerwacja();
                    rezerwacja.SprzetID = id;
                    rezerwacja.TypSprzetu = "buty";
                    rezerwacja.DataOdbioru = dataOdbioru;
                    rezerwacja.DataZwrotu = dataZwrotu;

                    db.Rezerwacje.Add(rezerwacja);
                    db.SaveChanges();

                    ViewBag.SuccessMessage = "Rezerwacja butów narciarskich zakończona pomyślnie.";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Nieznany typ sprzętu.";
                return RedirectToAction("Index");
            }
        }
    }
}
