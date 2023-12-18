window.getSelectedValues = function (sel) {
    var results = [];
    var i;
    for (i = 0; i < sel.options.length; i++) {
        if (sel.options[i].selected) {
            results[results.length] = sel.options[i].value;
        }
    }
    return results;
};
window.scrollToTop = () => {
    const element = document.documentElement;
    element.scrollTo({
        top: 0,
        left: 0,
        behavior: "smooth"
    });
};
