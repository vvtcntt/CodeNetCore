var productController = function () {
    this.initialize = function () {
        loadData();
         registerEvents();
    }

    function registerEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            thiepvu.configs.pageSize = $(this).val();
            thiepvu.configs.pageIndex = 1;
            loadData(true);
        });
    }

    function loadData(isPageChanged) {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                categoryId: null,
                keyword: $('#txtKeyword').val(),
                page: thiepvu.configs.pageIndex,
                pageSize: thiepvu.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            dataType: 'json',
            success: function (response) {
                console.log(response);
                $.each(response.Results, function (i, item) {
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
                    $('#lblTotalRecords').text(response.RowCount);
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        
                        loadData(isPageChanged);
                    }, isPageChanged);
                });
            },
            error: function (status) {
                console.log(status);
                thiepvu.notify('Cannot loading data', 'error');
            }
        });
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / thiepvu.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                thiepvu.configs.pageIndex = p;
                setTimeout(callBack(),100);
            }
        });
    }

}



