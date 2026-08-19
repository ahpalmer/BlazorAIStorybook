// Focus helper: @ref goes stale when a keyed subtree is rebuilt mid page-turn.
window.storybook = {
    focus: function (selector) {
        const el = document.querySelector(selector);
        if (!el) {
            return;
        }
        const page = el.closest('.page-inner');
        if (page) {
            page.scrollTop = 0;
        }
        el.focus({ preventScroll: true });
    }
};
