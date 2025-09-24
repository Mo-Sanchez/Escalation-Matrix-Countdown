window.kiosk = {
    enter: function () {
        if (!document.body.classList.contains('kiosk')) document.body.classList.add('kiosk');
        if (document.documentElement.requestFullscreen) document.documentElement.requestFullscreen();
    },
    exit: function () {
        document.body.classList.remove('kiosk');
        if (document.fullscreenElement && document.exitFullscreen) document.exitFullscreen();
    }
};
