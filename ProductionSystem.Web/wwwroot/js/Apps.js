document.addEventListener("DOMContentLoaded", () => {
    initializeDragAndDrop("dropzone");

    document.querySelectorAll(".submenu-item").forEach(item => {
        item.onclick = () => {
            location.href = item.dataset.href;
        };
        item.addEventListener("dragstart", (e) => {
            e.dataTransfer.setData("label", item.textContent.trim());
            e.dataTransfer.setData("href", item.dataset.href);
        });
    });
});

function initializeDragAndDrop(dropzoneId) {
    const dropzone = document.getElementById(dropzoneId);

    dropzone.addEventListener("dragover", (e) => e.preventDefault());

    dropzone.addEventListener("drop", (e) => {
        e.preventDefault();
        const label = e.dataTransfer.getData("label");
        const href = e.dataTransfer.getData("href");
        const existingBtn = [...dropzone.children].find(b => b.dataset.label === label);

        // 이미 존재하는 버튼을 다시 드롭한 경우 → 위치 이동만 허용
        if (existingBtn) {
            dropzone.appendChild(existingBtn);
            return;
        }

        // 새로운 버튼 생성
        const btn = document.createElement("div");
        btn.className = "app-button draggable-button";
        btn.textContent = label;
        btn.dataset.label = label;
        btn.onclick = () => {
            location.href = href;
        };

        // 삭제 버튼 추가
        const del = document.createElement("span");
        del.textContent = "❌";
        del.style.marginLeft = "10px";
        del.style.cursor = "pointer";
        del.onclick = (e) => {
            e.stopPropagation();
            dropzone.removeChild(btn);
        };
        btn.appendChild(del);

        // 드래그 가능 설정
        btn.draggable = true;
        btn.addEventListener("dragstart", (e) => {
            e.dataTransfer.setData("label", btn.dataset.label);
            e.target.classList.add("dragging");
        });
        btn.addEventListener("dragend", (e) => {
            e.target.classList.remove("dragging");
        });

        dropzone.appendChild(btn);
    });
}