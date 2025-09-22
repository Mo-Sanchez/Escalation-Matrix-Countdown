window.kiosk = {
    enter: function () {
        const el = document.documentElement;
        if (el.requestFullscreen) el.requestFullscreen();
        document.body.classList.add("kiosk-mode");
    },
    exit: function () {
        if (document.fullscreenElement) document.exitFullscreen();
        document.body.classList.remove("kiosk-mode");
    }
};
