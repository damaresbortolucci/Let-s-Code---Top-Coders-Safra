const image = document.querySelector('img')

image.addEventListener('click',()=>{

    document.body.classList.toggle('dark-mode')
    const src = image.getAttribute('src'); 

    if(src == './img/lampada-ligada.png')
        image.setAttribute('src', './img/lampada-desligada.png');
    else
        image.setAttribute('src', './img/lampada-ligada.png');     
})