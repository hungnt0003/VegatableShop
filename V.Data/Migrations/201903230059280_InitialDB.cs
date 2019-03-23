namespace V.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String(maxLength: 256));
            DropColumn("dbo.Products", "CreateDate");
            DropColumn("dbo.Products", "UpdateBy");
            DropColumn("dbo.ProductCategories", "CreateDate");
            DropColumn("dbo.ProductCategories", "UpdateBy");
            DropColumn("dbo.Pages", "CreateDate");
            DropColumn("dbo.Pages", "UpdateBy");
            DropColumn("dbo.PostCategories", "CreateDate");
            DropColumn("dbo.PostCategories", "UpdateBy");
            DropColumn("dbo.Posts", "CreateDate");
            DropColumn("dbo.Posts", "UpdateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "UpdateBy", c => c.String());
            AddColumn("dbo.Posts", "CreateDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdateBy", c => c.String());
            AddColumn("dbo.PostCategories", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdateBy", c => c.String());
            AddColumn("dbo.Pages", "CreateDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdateBy", c => c.String());
            AddColumn("dbo.ProductCategories", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdateBy", c => c.String());
            AddColumn("dbo.Products", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String());
            AlterColumn("dbo.PostCategories", "CreatedBy", c => c.String());
            AlterColumn("dbo.Pages", "CreatedBy", c => c.String());
            AlterColumn("dbo.ProductCategories", "CreatedBy", c => c.String());
            AlterColumn("dbo.Products", "CreatedBy", c => c.String());
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "UpdatedBy");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "UpdatedBy");
            DropColumn("dbo.Pages", "CreatedDate");
            DropColumn("dbo.ProductCategories", "UpdatedBy");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "UpdatedBy");
            DropColumn("dbo.Products", "CreatedDate");
        }
    }
}
