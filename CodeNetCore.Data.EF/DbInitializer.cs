using CodeNetCore.Data.Entites;
using CodeNetCore.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNetCore.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;
        public DbInitializer(AppDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Staff",
                    NormalizedName = "Staff",
                    Description = "Staff"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Customer",
                    NormalizedName = "Customer",
                    Description = "Customer"
                });
            }
            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                }, "123654$");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (_context.Functions.Count() == 0)
            {
                _context.Functions.AddRange(new List<Function>()
                {
                    new Function() {Id = "SYSTEM", Name = "Hệ thống",ParentId = null,Ord = 1,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "ROLE", Name = "Nhóm",ParentId = "SYSTEM",Ord = 1,Status = Status.Active,URL = "/admin/role/index",IconCss = "fa-home"  },
                    new Function() {Id = "FUNCTION", Name = "Chức năng",ParentId = "SYSTEM",Ord = 2,Status = Status.Active,URL = "/admin/function/index",IconCss = "fa-home"  },
                    new Function() {Id = "USER", Name = "Người dùng",ParentId = "SYSTEM",Ord =3,Status = Status.Active,URL = "/admin/user/index",IconCss = "fa-home"  },
                    new Function() {Id = "ACTIVITY", Name = "Nhật ký",ParentId = "SYSTEM",Ord = 4,Status = Status.Active,URL = "/admin/activity/index",IconCss = "fa-home"  },
                    new Function() {Id = "ERROR", Name = "Lỗi",ParentId = "SYSTEM",Ord = 5,Status = Status.Active,URL = "/admin/error/index",IconCss = "fa-home"  },
                    new Function() {Id = "SETTING", Name = "Cấu hình",ParentId = "SYSTEM",Ord = 6,Status = Status.Active,URL = "/admin/setting/index",IconCss = "fa-home"  },
                    new Function() {Id = "PRODUCT",Name = "Sản phẩm",ParentId = null,Ord = 2,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CATEGORY",Name = "Danh mục",ParentId = "PRODUCT",Ord =1,Status = Status.Active,URL = "/admin/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_LIST",Name = "Sản phẩm",ParentId = "PRODUCT",Ord = 2,Status = Status.Active,URL = "/admin/product/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "BILL",Name = "Hóa đơn",ParentId = "PRODUCT",Ord = 3,Status = Status.Active,URL = "/admin/bill/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "CONTENT",Name = "Nội dung",ParentId = null,Ord = 3,Status = Status.Active,URL = "/",IconCss = "fa-table"  },
                    new Function() {Id = "BLOG",Name = "Bài viết",ParentId = "CONTENT",Ord = 1,Status = Status.Active,URL = "/admin/blog/index",IconCss = "fa-table"  },
                    new Function() {Id = "UTILITY",Name = "Tiện ích",ParentId = null,Ord = 4,Status = Status.Active,URL = "/",IconCss = "fa-clone"  },
                    new Function() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",Ord = 1,Status = Status.Active,URL = "/admin/footer/index",IconCss = "fa-clone"  },
                    new Function() {Id = "FEEDBACK",Name = "Phản hồi",ParentId = "UTILITY",Ord = 2,Status = Status.Active,URL = "/admin/feedback/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ANNOUNCEMENT",Name = "Thông báo",ParentId = "UTILITY",Ord = 3,Status = Status.Active,URL = "/admin/announcement/index",IconCss = "fa-clone"  },
                    new Function() {Id = "CONTACT",Name = "Liên hệ",ParentId = "UTILITY",Ord = 4,Status = Status.Active,URL = "/admin/contact/index",IconCss = "fa-clone"  },
                    new Function() {Id = "SLIDE",Name = "Slide",ParentId = "UTILITY",Ord = 5,Status = Status.Active,URL = "/admin/slide/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ADVERTISMENT",Name = "Quảng cáo",ParentId = "UTILITY",Ord = 6,Status = Status.Active,URL = "/admin/advertistment/index",IconCss = "fa-clone"  },

                    new Function() {Id = "REPORT",Name = "Báo cáo",ParentId = null,Ord = 5,Status = Status.Active,URL = "/",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "REVENUES",Name = "Báo cáo doanh thu",ParentId = "REPORT",Ord = 1,Status = Status.Active,URL = "/admin/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "ACCESS",Name = "Báo cáo truy cập",ParentId = "REPORT",Ord = 2,Status = Status.Active,URL = "/admin/report/visitor",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "READER",Name = "Báo cáo độc giả",ParentId = "REPORT",Ord = 3,Status = Status.Active,URL = "/admin/report/reader",IconCss = "fa-bar-chart-o"  },
                });
            }

             

            if (_context.Colors.Count() == 0)
            {
                List<Color> listColor = new List<Color>()
                {
                    new Color() {Name="Đen", Code="#000000" },
                    new Color() {Name="Trắng", Code="#FFFFFF"},
                    new Color() {Name="Đỏ", Code="#ff0000" },
                    new Color() {Name="Xanh", Code="#1000ff" },
                };
                _context.Colors.AddRange(listColor);
            }
             

             


            if (_context.Sizes.Count() == 0)
            {
                List<Size> listSize = new List<Size>()
                {
                    new Size() { Name="XXL" },
                    new Size() { Name="XL"},
                    new Size() { Name="L" },
                    new Size() { Name="M" },
                    new Size() { Name="S" },
                    new Size() { Name="XS" }
                };
                _context.Sizes.AddRange(listSize);
            }

            if (_context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Áo nam",Alias="ao-nam",ParentId = null,Status=Status.Active,Ord=1,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Sản phẩm 1",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-1",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 2",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-2",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 3",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-3",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 4",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-4",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 5",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-5",Price = 1000,Status = Status.Active},
                        }
                    },
                    new ProductCategory() { Name="Áo nữ",Alias="ao-nu",ParentId = null,Status=Status.Active ,Ord=2,
                        Products = new List<Product>() 
                        {
                            new Product(){Name = "Sản phẩm 6",ImageDetail="/client-side/images/products/product-1.jpg",Alias= "san-pham-6",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 7",ImageDetail="/client-side/images/products/product-1.jpg",Alias= "san-pham-7",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 8",ImageDetail="/client-side/images/products/product-1.jpg",Alias= "san-pham-8",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 9",ImageDetail="/client-side/images/products/product-1.jpg",Alias= "san-pham-9",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 10",ImageDetail  ="/client-side/images/products/product-1.jpg",Alias = "san-pham-10",Price = 1000,Status = Status.Active},
                        }},
                    new ProductCategory() { Name="Giày nam",Alias="giay-nam",ParentId = null,Status=Status.Active ,Ord=3,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Sản phẩm 11",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-11",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 12",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-12",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 13",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-13",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 14",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-14",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 15",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-15",Price = 1000,Status = Status.Active},
                        }},
                    new ProductCategory() { Name="Giày nữ",Alias="giay-nu",ParentId = null,Status=Status.Active,Ord=4,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Sản phẩm 16",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-16",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 17",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-17",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 18",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-18",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 19",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-19",Price = 1000,Status = Status.Active},
                            new Product(){Name = "Sản phẩm 20",ImageDetail="/client-side/images/products/product-1.jpg",Alias = "san-pham-20",Price = 1000,Status = Status.Active},
                        }}
                };
                _context.ProductCategories.AddRange(listProductCategory);
            }

            if (!_context.Configs.Any(x => x.Id == "HomeTitle"))
            {
                _context.Configs.Add(new Config()
                {
                    Id = "HomeTitle",
                    Name = "Tiêu đề trang chủ",
                   
                });
            }
           
        }

    }
}
