window.themeManager = {
    getTheme: () => localStorage.getItem('babidi-theme') || 'light',
    applyTheme: (theme) => {
        const isDark = theme === 'dark';
        document.documentElement.classList.toggle('dark', isDark);
        localStorage.setItem('babidi-theme', isDark ? 'dark' : 'light');
    }
};
