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
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE01", Name = "���ˬ���¸�k���� (��)", Picture = "http://shop.drsox.tw/images/index6_SE01.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE02", Name = "���ˬ���¸�k���� (�L��)", Picture = "http://shop.drsox.tw/images/index6_SE02.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE03", Name = "�`�̦ˬ���¸�e�f�� (��)", Picture = "http://shop.drsox.tw/images/index6_SE03.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE04", Name = "�`�̦ˬ���¸�e�f�� (�`��)", Picture = "http://shop.drsox.tw/images/index6_SE04.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE05", Name = "�ˬ��e�f����������� (��/��)", Picture = "http://shop.drsox.tw/images/index6_SE05.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE06", Name = "�ˬ��e�f����������� (�L��/��)", Picture = "http://shop.drsox.tw/images/index6_SE06.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE07", Name = "�ˬ��e�f������u���� (��/��)", Picture = "http://shop.drsox.tw/images/index6_SE07.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE08", Name = "�ˬ��e�f�����𶢵u�� (�L��/��)", Picture = "http://shop.drsox.tw/images/index6_SE8.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE09", Name = "�ˬ��e�f�����𶢵u�� (��/��)", Picture = "http://shop.drsox.tw/images/index6_SE09.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL10", Name = "�ˬ��B�ʮ���� (��/��)", Picture = "http://shop.drsox.tw/images/index6_SL10.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL11", Name = "�ˬ��B�ʮ���� (�ɩ|��)", Picture = "http://shop.drsox.tw/images/index6_SL11.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL12", Name = "�ˬ��B�ʲ�� (��)", Picture = "http://shop.drsox.tw/images/index6_SL12.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL13", Name = "�ˬ��L�����d�� (��)", Picture = "http://shop.drsox.tw/images/index6_SL13.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL14", Name = "�ˬ��L�����d�� (��)", Picture = "http://shop.drsox.tw/images/index6_SL14.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL15", Name = "�ˬ����k�� (��/��)", Picture = "http://shop.drsox.tw/images/index6_SL15.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL16", Name = "�ˬ����k�� (��/��)", Picture = "http://shop.drsox.tw/images/index6_SL17.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL17", Name = "�ˬ����k�� (�u/��)", Picture = "http://shop.drsox.tw/images/index6_SL16.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL18", Name = "�ˬ����k�� (�u/��)", Picture = "http://shop.drsox.tw/images/index6_SL18.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL19", Name = "�ˬ��B�ʮ���� (��/��)", Picture = "http://shop.drsox.tw/images/SL19.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SL20", Name = "�ˬ��ǥ͹B�ʳz����(��/��)", Picture = "http://shop.drsox.tw/images/SL20.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE21", Name = "�ˬ��ǥ͹B�ʳz����(��/��)", Picture = "http://shop.drsox.tw/images/SL21.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE22", Name = "�ˬ��y��������(�ձ���)", Picture = "http://shop.drsox.tw/images/SE22.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE23", Name = "�ˬ��y��������(������)", Picture = "http://shop.drsox.tw/images/SE23.jpg" },
                new ProductEntity() { Price = 120, IsNew = true, IsHot = true, Show = true, Code = "SE24", Name = "�ξA�L�����d��", Picture = "http://shop.drsox.tw/images/SE24.jpg" });
        }
    }
}
