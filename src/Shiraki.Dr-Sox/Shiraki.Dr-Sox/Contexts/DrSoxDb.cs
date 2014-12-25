namespace Shiraki.Dr_Sox.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.Serialization;

    public class DrSoxDb : DbContext
    {
        // 您的內容已設定為使用應用程式組態檔 (App.config 或 Web.config)
        // 中的 'DrSoxDb' 連接字串。根據預設，這個連接字串的目標是
        // 您的 LocalDb 執行個體上的 'Shiraki.DrSoxDb' 資料庫。
        // 
        // 如果您的目標是其他資料庫和 (或) 提供者，請修改
        // 應用程式組態檔中的 'DrSoxDb' 連接字串。
        public DrSoxDb()
            : base("name=DrSoxDb")
        {
            Database.SetInitializer<DrSoxDb>(new CreateDatabaseIfNotExists<DrSoxDb>());
        }

        // 針對您要包含在模型中的每種實體類型新增 DbSet。如需有關設定和使用
        // Code First 模型的詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=390109。

        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }
        public virtual DbSet<OrderItemEntity> OrderItems { get; set; }
    }

    [Table("Products")]
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }

        public bool IsNew { get; set; }
        public bool IsHot { get; set; }
        public bool Show { get; set; }

        public ProductEntity()
        {
            OrderItemEntities = new HashSet<OrderItemEntity>();
        }
        public virtual ICollection<OrderItemEntity> OrderItemEntities { get; set; }
    }

    [Table("Orders")]
    public class OrderEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAreaCode { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientTown { get; set; }
        public string RecipientAddr { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? ChangeTime { get; set; }

        public OrderEntity()
        {
            OrderItemEntities = new HashSet<OrderItemEntity>();
        }
        public virtual ICollection<OrderItemEntity> OrderItemEntities { get; set; }
    }

    [Table("OrderItems")]
    public class OrderItemEntity
    {
        public int Id { get; set; }
        public int OrderEntityId { get; set; }
        public int ProductEntityId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual OrderEntity OrderEntity { get; set; }
        public virtual ProductEntity ProductEntity { get; set; }
    }
}