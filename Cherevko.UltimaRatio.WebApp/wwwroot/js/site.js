/// <reference path="../lib/jquery/dist/jquery.js" />


$(".menu-main").click(function (event) {
	$($(".menu-main").find(".current").first()).removeClass("current");
	$(event.target).addClass("current");
});