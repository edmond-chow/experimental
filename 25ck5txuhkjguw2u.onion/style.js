var styleLoad = setInterval(function(){
    if(document.readyState == 'complete'){
        clearInterval(styleLoad);
        styleOnload();
    };
},100);
function elementInViewport(el){
    var rect = el.getBoundingClientRect();
    var Left = ( rect.x<(window.innerWidth || document.documentElement.clientWidth) );
    var Top = ( rect.y<(window.innerHeight || document.documentElement.clientHeight) );
    var Right = ( rect.x+el.offsetWidth>0 );
    var Bottom = ( rect.y+el.offsetHeight>0 );
    return (
        (Left&&Right)&&(Top&&Bottom)
    );
};
function styleOnload(){
    setInterval(function(){
        for(i=0;i<document.querySelectorAll('ul#Top-Navigation-Bar').length;i++){
            if(document.body.clientWidth>1226){
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.remove('Top-Navigation-Bar-Small');
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.remove('Top-Navigation-Bar-Medium');
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.add('Top-Navigation-Bar-Large');
            }else if(document.body.clientWidth>=1048){
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.remove('Top-Navigation-Bar-Small');
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.add('Top-Navigation-Bar-Medium');
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.remove('Top-Navigation-Bar-Large');
            }else{
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.add('Top-Navigation-Bar-Small');
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.remove('Top-Navigation-Bar-Medium');
                document.querySelectorAll('ul#Top-Navigation-Bar')[i].classList.remove('Top-Navigation-Bar-Large');
            };
        };
    },50);
    setInterval(function(){
        var aBackgroundImageDownloadButton = document.querySelectorAll('a#background-image-download-button');
        var buttonButtondIcon = document.querySelectorAll('button.buttond-icon');
        var thSx = document.querySelectorAll('dir.mother-kx > dir.kx > table.kx-table > tbody > tr > th.sx');
        function buttonButtondButtondSmall(i){
            return thSx[i].querySelectorAll('a > button.buttond.buttond-small');
        };
        var dirKx = document.querySelectorAll('dir.mother-kx>dir.kx');
        function kxContent(i){
            return dirKx[i].querySelectorAll('dir.kx-content');
        };
        var dirKx_divDropdown = document.querySelectorAll('dir.kx,div.dropdown');
        function h4(i){
            return dirKx[i].querySelectorAll('table.kx-table>tbody>tr>th>table.s>tbody>tr>th.s>h4');
        };
        function pKxP(i){
            return dirKx[i].querySelectorAll('p.kx-p');
        };
        /*Set bg*/
        for(i=0;i<aBackgroundImageDownloadButton.length;i++){
            var src = window.getComputedStyle(document.body).getPropertyValue('background-image');
            if(src.substring(0,5)=='url("'||src.substring(0,5)=="url('"){
                src=src.substring(5,src.length-2);
            }else if(src.substring(0,4)=='url('){
                src=src.substring(4,src.length-1);
            };
            aBackgroundImageDownloadButton[i].setAttribute('href',src);
        };
        /*Set button.buttond-icon.NoContent*/
        for(i=0;i<buttonButtondIcon.length;i++){
            if(buttonButtondIcon[i].innerHTML.replace(/\n/g, '').replace(/ /g, '')==''){
                buttonButtondIcon[i].classList.add('NoContent');
            }else{
                buttonButtondIcon[i].classList.remove('NoContent');
            };
        };
        /*Set dir.mother-kx > dir.kx > table.kx-table > tbody > tr > th.sx*/
        for(i=0;i<thSx.length;i++){
            var innerHTML = '';
            for(s=0;s<buttonButtondButtondSmall(i).length;s++){
                innerHTML += buttonButtondButtondSmall(i)[s].parentElement.outerHTML;
            };
            if(thSx[i].innerHTML != innerHTML){
                thSx[i].innerHTML = innerHTML;
            };
        };
        /*Set dir.kx.NoContent*/
        for(i=0;i<dirKx.length;i++){
            dirKx[i].style.zIndex=dirKx.length-i;
            for(c=0;c<kxContent(i).length;c++){
                if(kxContent(i)[0].innerHTML.replace(/\n/g, '').replace(/ /g, '')==''){
                    dirKx[i].classList.add('NoContent');
                }else{
                    dirKx[i].classList.remove('NoContent');
                };
            };
        };
        /*Set dir.kx,div.dropdown*/
        for(i=0;i<dirKx_divDropdown.length;i++){
            if(dirKx_divDropdown[i].style.zIndex!=(dirKx_divDropdown.length-i).toString()){
               dirKx_divDropdown[i].style.zIndex=dirKx_divDropdown.length-i;
            };
        };
        /*Set p.kx-p*/
        for(i=0;i<dirKx.length;i++){
            for(c=0;c<h4(i).length;c++){
                if(h4(i)[0].innerHTML.substring(0,1)=='#'){}else{
                    h4(i)[0].innerHTML='#'+h4(i)[0].innerHTML;
                };
                for(p=0;p<pKxP(i).length;p++){
                    pKxP(i)[0].id=h4(i)[0].innerHTML.substring(1,h4(i)[0].innerHTML.length);
                };
            };
        };
    }, 500);
    /* GoldenRatioFrame */
    setInterval(function(){
        for(i=0;i<document.querySelectorAll('div.s-width.r-height').length;i++){
            document.querySelectorAll('div.s-width.r-height')[i].style.height=document.querySelectorAll('div.s-width.r-height')[i].offsetWidth/16*9+'px';
        };
        for(i=0;i<document.querySelectorAll('div.s-height.r-width').length;i++){
            document.querySelectorAll('div.s-height.r-width')[i].style.width=document.querySelectorAll('div.s-height.r-width')[i].offsetHeight/9*16+'px';
        };
    },100);
    /* LazyLoad */
    setInterval(function(){
        var lazyImage = document.getElementsByClassName('lazy');
        for(i=0;i<lazyImage.length;i++){
            if(elementInViewport(lazyImage[i])){
                lazyImage[i].setAttribute('src',lazyImage[i].getAttribute('data-src'));
                if(lazyImage[i].tagName=='IFRAME'){
                    lazyImage[i].classList.remove('lazy');
                };
            };
        };
    },100);
    /* ScrollIntoView */
    setTimeout(function(){
        var scrollTimes = 0;
        var scrolling = setInterval(function(){
            scrollTimes=scrollTimes+1;
            if(scrollTimes>=10){clearInterval(scrolling);};
            if(document.location.hash.substring(1,document.location.hash.length)==''){}else{document.getElementById(document.location.hash.substring(1,document.location.hash.length)).scrollIntoView();};
        },500);
    },1500);
};