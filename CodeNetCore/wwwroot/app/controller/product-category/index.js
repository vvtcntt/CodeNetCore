var productCategoryController = function () {
    this.initialize = function () {
        loadData();
    }
    function loadData() {
        $.ajax({
            url: '/admin/productCategory/getall',
            dataType: 'json',
            success: function (response) {
                var data = [];
                $.each(response, function (i, item) {
                    data.push({
                        id: item.Id,
                        text: item.Name,
                        parentId: item.ParentId,
                        ord: item.Ord

                    });
                   
                });
                var treeArr = thiepvu.unflattern(data);
                //var $tree = $('#treeProductCategogy');
                $('#treeProductCategory').tree({
                    data: treeArr,
                    dnd:true
                })
            }
        });
    }
}