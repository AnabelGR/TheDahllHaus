jQuery(document).ready(function ($) {
    //if ($('#menu1').hasClass('menu-full-width')) {
    //$(this).addClass('hellooo');
    jQuery('ul.uk-navbar-nav li .menu-full-width').parent().attr('data-uk-dropdown', "{justify: '#menu1'}");
    //}
});