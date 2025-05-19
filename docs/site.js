window.onBeforeUnloadHandler = {
    attachUnloadListener: function () {
        window.addEventListener('beforeunload', function () {
            localStorage.removeItem('selectedLanguage');
            localStorage.removeItem('quantity');
        });
    }
};
