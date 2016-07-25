
    "use strict";
    function getAllProducts() {
        $.getJSON("api/products")
            .done(function (data) {
                $('#tableBody').empty();
                // On success, 'data' contains a list of products.
                $.each(data, function (key, item) {
                    // Add a list item for the product.
                    var html = '<tr>';
                    html += "<td>" + item.Name + "</td>";
                    html += "<td><a class=\"btn btn-default\" onclick=\"getDetail(" + item.Id + ")\">See Detail</a></td>";
                    html += "<td>" + item.Slug + "</td>";
                    html += "<td>" + item.Description + "</td>";
                    html += "<td>$" + item.Price + "</td>";
                    html += "<td><img src=\"" + item.ImageUrl + "\" title=\"" + item.Name + "\" /></td>";
                    html += "</tr>";
                    $(html).appendTo($('#tableBody'));
                });
            });
    }

    function formatItem(item) {
        return item.Name + ': $' + item.Price;
    }

    function getDetail(productId) {
        var id = $('#prodId').val();
        $.getJSON('api/product/' + productId)
            .done(function (data) {
                var html = "<p>Product Name : " + data.Name + "</p>";
                html    += "<p>Slug         : " + data.Slug + "</p>";
                html    += "<p>Description  : " + data.Description + "</p>";
                html    += "<p>Price        : $" + data.Price + "</p>";
                $('#result').html(html);
            })
            .fail(function (jqXHR, textStatus, err) {
                $('#result').text('Error: ' + err);
            });
    }