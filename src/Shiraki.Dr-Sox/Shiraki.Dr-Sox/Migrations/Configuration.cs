using Shiraki.Dr_Sox.Contexts;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Shiraki.Dr_Sox.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DrSoxDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DrSoxDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.AddOrUpdate(e => e.Code,
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE01", Name = "¥þ¦Ë¬´¨ëÂ¸¨k¥ð¶¢Äû (¶Â)", Picture = "http://shop.drsox.tw/images/index6_SE01.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE02", Name = "¥þ¦Ë¬´¨ëÂ¸¨k¥ð¶¢Äû (²L¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SE02.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE03", Name = "©`¦Ì¦Ë¬´¨ëÂ¸¼e¤fÄû (¶Â)", Picture = "http://shop.drsox.tw/images/index6_SE03.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE04", Name = "©`¦Ì¦Ë¬´¨ëÂ¸¼e¤fÄû (²`¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SE04.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE05", Name = "¦Ë¬´¼e¤f±ø¯¾¥ðªø¶¢Äû (¶Â/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SE05.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE06", Name = "¦Ë¬´¼e¤f±ø¯¾¥ðªø¶¢Äû (²L¦Ç/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SE06.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE07", Name = "¦Ë¬´¼e¤f±ø¯¾¥ðµu¶¢Äû (¶Â/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SE07.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE08", Name = "¦Ë¬´¼e¤f±ø¯¾¥ð¶¢µuÄû (²L¦Ç/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SE8.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE09", Name = "¦Ë¬´¼e¤f±ø¯¾¥ð¶¢µuÄû (¶Â/µµ)", Picture = "http://shop.drsox.tw/images/index6_SE09.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL10", Name = "¦Ë¬´¹B°Ê®ð¹ÔÄû (¶Â/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SL10.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL11", Name = "¦Ë¬´¹B°Ê®ð¹ÔÄû (®É©|¶Â)", Picture = "http://shop.drsox.tw/images/index6_SL11.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL12", Name = "¦Ë¬´¹B°Ê²î«¬Äû (¶Â)", Picture = "http://shop.drsox.tw/images/index6_SL12.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL13", Name = "¦Ë¬´µL²ª°·±dÄû (¶Â)", Picture = "http://shop.drsox.tw/images/index6_SL13.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL14", Name = "¦Ë¬´µL²ª°·±dÄû (¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SL14.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL15", Name = "¦Ë¬´¤­³kÄû (ªø/¶Â)", Picture = "http://shop.drsox.tw/images/index6_SL15.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL16", Name = "¦Ë¬´¤­³kÄû (ªø/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SL17.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL17", Name = "¦Ë¬´¤­³kÄû (µu/¶Â)", Picture = "http://shop.drsox.tw/images/index6_SL16.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL18", Name = "¦Ë¬´¤­³kÄû (µu/¦Ç)", Picture = "http://shop.drsox.tw/images/index6_SL18.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL19", Name = "¦Ë¬´¹B°Ê®ð¹ÔÄû (¶Â/¦Ç)", Picture = "http://shop.drsox.tw/images/SL19.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL20", Name = "¦Ë¬´¾Ç¥Í¹B°Ê³z®ðÄû(¥Õ/¦Ç)", Picture = "http://shop.drsox.tw/images/SL20.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE21", Name = "¦Ë¬´¾Ç¥Í¹B°Ê³z®ðÄû(¥Õ/¦Ç)", Picture = "http://shop.drsox.tw/images/SL21.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE22", Name = "¦Ë¬´¬y¦æ±ø¯¾²î«¬Äû(¥Õ±ø¯¾)", Picture = "http://shop.drsox.tw/images/SE22.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE23", Name = "¦Ë¬´¬y¦æ±ø¯¾²î«¬Äû(¬õ±ø¯¾)", Picture = "http://shop.drsox.tw/images/SE23.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE24", Name = "µÎ¾AµL²ª°·±dÄû", Picture = "http://shop.drsox.tw/images/SE24.jpg" });
        }
    }
}
