(function ($) {

    var methods = {
        init: function (options) {
            var button = $('<div></div>');
            button.text('Cart');
            this.append(button);

            var dropdown = $('<div></div>');

        }
    };

    $.fn.shoppingCart = function (method) {

        // Method calling logic
        if (methods[method]) {
            return methods[method].apply(this, Array.prototype.slice.call(arguments, 1));
        } else if (typeof method === 'object' || !method) {
            return methods.init.apply(this, arguments);
        } else {
            $.error('Method ' + method + ' does not exist on jQuery.shoppingCart');
        }

    };

})(jQuery);