using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiThiMau.Models.Entity;
using System.Data.Entity;

namespace BaiThiMau.Controllers
{
    public class LayoutController : Controller
    {
        QLVaLi db = new QLVaLi();
        // GET: Layout
        public ActionResult Index()
        {
            return View(db.tDanhMucSPs);
        }
        public ActionResult CreateMenu()
        {
            return PartialView(db.tQuocGias);
        }
        public ActionResult GetItem(string manuoc) 
        {
            return View("Index", db.tDanhMucSPs.Where(p => p.MaNuocSX == manuoc));
        }
        public ActionResult LoadDetails(string id)
        {
            return View(db.tDanhMucSPs.Where(p=> p.MaSP.Equals(id)).First());
        }
        [HttpPost]
        public ActionResult DeleteProduct(string id,int ?linhtinh)
        {
            db.tDanhMucSPs.Remove(db.tDanhMucSPs.Where(p => p.MaSP.Equals(id)).First());
            db.SaveChanges();
            return View("Index",db.tDanhMucSPs);
        }
        public ActionResult DeleteProduct(string id)
        {
            
            return View(db.tDanhMucSPs.Where(p => p.MaSP.Equals(id)).First());
        }
        public ActionResult EditProduct(string id)
        {
            ViewBag.MaChatLieu = new SelectList(db.tChatLieux, "MaChatLieu", "ChatLieu");
            ViewBag.MaNuocSX = new SelectList(db.tQuocGias, "MaNuoc", "TenNuoc");
            ViewBag.MaHangSX = new SelectList(db.tHangSXes, "MaHangSX", "HangSX");
            ViewBag.MaDT = new SelectList(db.tLoaiDTs, "MaDT", "TenLoai");
            ViewBag.MaLoai = new SelectList(db.tLoaiSPs, "MaLoai", "Loai");
            ViewBag.MaKichThuoc = new SelectList(db.tKichThuocs, "MaKichThuoc", "KichThuoc");

            return View(db.tDanhMucSPs.Where(p => p.MaSP.Equals(id)).First());
        }
        [HttpPost]
        public ActionResult EditProduct(tDanhMucSP sp)
        {
            db.Entry(sp).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult CreateProduct()
        {
            ViewBag.MaChatLieu = new SelectList(db.tChatLieux, "MaChatLieu", "ChatLieu");
            ViewBag.MaNuocSX = new SelectList(db.tQuocGias, "MaNuoc", "TenNuoc");
            ViewBag.MaHangSX = new SelectList(db.tHangSXes, "MaHangSX", "HangSX");
            ViewBag.MaDT = new SelectList(db.tLoaiDTs, "MaDT", "TenLoai");
            ViewBag.MaLoai = new SelectList(db.tLoaiSPs, "MaLoai", "Loai");
            ViewBag.MaKichThuoc = new SelectList(db.tKichThuocs, "MaKichThuoc", "KichThuoc");
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(tDanhMucSP sp)
        {
            db.tDanhMucSPs.Add(sp);
            db.SaveChanges();
            return View("Index", db.tDanhMucSPs);
        }



    }
}