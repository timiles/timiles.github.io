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
