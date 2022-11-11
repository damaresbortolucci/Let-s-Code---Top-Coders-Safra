const background = document.querySelector('img')

background.addEventListener('click',()=>{

    document.body.classList.toggle('dark-mode')
    const img = background.getAttribute('src'); 

    if(img == './img/lampada-ligada.png')
        background.setAttribute('src', './img/lampada-desligada.png');
    else
        background.setAttribute('src', './img/lampada-ligada.png');     
})