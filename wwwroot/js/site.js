(() => {
    const searchInput = document.getElementById("productSearch");
    const productCards = Array.from(document.querySelectorAll("[data-product-card]"));
    const resultCount = document.getElementById("resultsCount");
    const emptyState = document.getElementById("emptyState");
    const selectedCategory = new URLSearchParams(window.location.search).get("category") || "";

    if (!searchInput || productCards.length === 0) {
        return;
    }

    const filterProducts = () => {
        const searchTerm = searchInput.value.trim().toLocaleLowerCase("kk-KZ");
        let visibleCount = 0;

        for (const card of productCards) {
            const name = (card.dataset.name || "").toLocaleLowerCase("kk-KZ");
            const category = card.dataset.category || "";
            const matchesSearch = name.includes(searchTerm);
            const matchesCategory = !selectedCategory || category === selectedCategory;
            const isVisible = matchesSearch && matchesCategory;

            card.hidden = !isVisible;
            if (isVisible) {
                visibleCount += 1;
            }
        }

        if (resultCount) {
            resultCount.textContent = visibleCount.toString();
        }

        if (emptyState) {
            emptyState.classList.toggle("d-none", visibleCount > 0);
        }
    };

    searchInput.addEventListener("input", filterProducts);
    filterProducts();
})();
