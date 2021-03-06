﻿(function(){
    
    var ServiceGallery = function (selector, child) {
		var servicesGallery = $(selector);
        var servicesContent = servicesGallery.find(child);

		var equalHeight = function () {
			// Find content height of each item
			var max = 0;

			// Remove fixed height for re-calculate
			servicesContent.removeAttr('style');

			// just for desktop (3 columns)
			if ($(window).width() > 767) {
				servicesContent.promise().done(function () {
				    // Find max height
				    servicesContent.each(function (i) {
				        var $this = $(this);

				        if (max < $this.height()) max = $this.height();
				    });

				    // Set same height for all
				    servicesContent.css('height', max);
				});
			}
            
		}
        
		var init = function () {
			// Check ele defined or not
			if (typeof servicesGallery !== 'undefined' && typeof servicesContent !== 'undefined') {
				// Call at the first time loaded
				equalHeight();

				// Resize to calculate
                $(window).resize($.debounce(20, equalHeight));
			}
        }
        
        return {
            init: init
        }
    }
    
	var servicesGallery = new ServiceGallery('.residential-service-gallery', ".residential-service-gallery__content");
    servicesGallery.init();

})();