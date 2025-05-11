function createPrisms() {
    const container = document.getElementById('container');
    const prismCount = 50;
    const hueBase = 240; // Azul base
    const hueVariation = 30;

    for (let i = 0; i < prismCount; i++) {
        const prism = document.createElement('div');
        prism.className = 'prism';

        // Posição aleatória
        const left = Math.random() * 100;
        const top = Math.random() * 100;

        // Tamanho aleatório
        const size = 10 + Math.random() * 40;

        // Cor aleatória dentro da variação
        const hue = hueBase + (Math.random() - 0.5) * hueVariation;
        const color = `hsla(${hue}, 70%, 50%, 0.4)`;

        // Ajustes de estilo
        prism.style.width = `${size}px`;
        prism.style.height = `${size}px`;
        prism.style.left = `${left}%`;
        prism.style.top = `${top}%`;
        prism.style.background = color;
        prism.style.animationDelay = `${Math.random() * 12}s`;

        // Efeito 3D
        prism.style.transform = `rotate(${Math.random() * 360}deg) scale(${0.8 + Math.random() * 0.4})`;

        container.appendChild(prism);
    }
}

document.addEventListener('DOMContentLoaded', createPrisms);

// Atualizar posições ao redimensionar a janela
window.addEventListener('resize', () => {
    const prisms = document.getElementsByClassName('prism');
    Array.from(prisms).forEach(prism => {
        prism.style.left = `${Math.random() * 100}%`;
        prism.style.top = `${Math.random() * 100}%`;
    });
});