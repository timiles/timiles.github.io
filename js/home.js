function initMap() {
    // gmaps:
    var $map = $('#map');
    var mapCenter = new google.maps.LatLng($map.data('lat'), $map.data('lng'));
    var map = new google.maps.Map($map[0], {
        zoom: $map.data('zoom'),
        center: mapCenter,
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        scrollwheel: false,
        draggable: false
    });

    new google.maps.Circle({
        map: map,
        center: map.center,
        radius: $map.data('radius'),
        fillColor: '#DAF4F0',
        strokeOpacity: 0.1
    });
}

$(function () {
    // main header: slide small header down when scrolling past large header
    $(window).scroll(function () {
        if ($(this).scrollTop() > $('#mainHeaderLarge').height()) {
            $('#mainHeaderSmall').slideDown();
        } else {
            $('#mainHeaderSmall').slideUp();
        }
    });
});
