var productController = function () {
    this.initialize = function () {
        loadData();
    }

    function registerEvents() {
        //todo: binding events to controls
    }

    function loadData() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'json',
            success: function (response) {
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        ImageThumbs: item.ImageThumbs == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.ImageThumbs + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: thiepvu.formatNumber(item.Price, 0),
                        PriceSale: item.PriceSale,
                        New: item.New,
                        HomeFlag: item.HomeFlag,
                        Code: item.Code,
                        Status: thiepvu.getStatus(item.Status)
                    });
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                });
            },
            error: function (status) {
                console.log(status);
                thiepvu.notify('Cannot loading data', 'error');
            }
        })
    }
}