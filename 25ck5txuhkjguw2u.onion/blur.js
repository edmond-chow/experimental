/*var img = new Image();
var blurLoad = setInterval(function(){
    if(document.readyState == 'complete'){
        clearInterval(blurLoad);
        blurOnload();
    };
},100);*/
/*function elementInTheport(el){
    var rect = el.getBoundingClientRect();
    var Left = ( rect.x<(window.innerWidth || document.documentElement.clientWidth)*2 );
    var Top = ( rect.y<(window.innerHeight || document.documentElement.clientHeight)*2 );
    var Right = ( rect.x+el.offsetWidth>0-(window.innerWidth || document.documentElement.clientWidth) );
    var Bottom = ( rect.y+el.offsetHeight>0-(window.innerHeight || document.documentElement.clientHeight) );
    return (
        (Left&&Right)&&(Top&&Bottom)
    );
};*/
function blurOnload(){
setInterval(function(){
    /*var parentMotherKx = 'dir#main-content-dir>dir#sub-main-content-dir>dir.mother-kx';
    var kxBlurred = 'dir.blur-boundary.kx-blurred-style';*/
    /*Add blur area*/
    /*for(u=0;u<document.querySelectorAll(parentMotherKx).length;u++){
        var n=false;
        for(ui=0;ui<document.querySelectorAll(parentMotherKx)[u].querySelectorAll(kxBlurred).length;ui++){
            n=true;
            break;
        };
        if(n==false){
            document.querySelectorAll(parentMotherKx)[u].innerHTML+='<dir class="blur-boundary kx-blurred-style"><dir class="blur"></dir></dir>';
        };
    };*/
    /*Set blur-boundary,kx-blurred-style property*/
    /*for(blurLoadI=0;blurLoadI<document.querySelectorAll(parentMotherKx+'>'+kxBlurred).length;blurLoadI++){
        document.querySelectorAll(parentMotherKx+'>'+kxBlurred)[blurLoadI].style.height=document.querySelectorAll(parentMotherKx+'>'+kxBlurred)[blurLoadI].parentElement.querySelector('dir.kx').offsetHeight+'px';
        document.querySelectorAll(parentMotherKx+'>'+kxBlurred)[blurLoadI].style.marginTop=-document.querySelectorAll(parentMotherKx+'>'+kxBlurred)[blurLoadI].parentElement.querySelector('dir.kx').offsetHeight+'px';
    };*/
    /*Get blur img*/
    /*var src = window.getComputedStyle(document.body).getPropertyValue('background-image');
    if(src.substring(0,5)=='url("'||src.substring(0,5)=="url('"){
        src=src.substring(5,src.length-2);
        img.src = src;
    }else if(src.substring(0,4)=='url('){
        src=src.substring(4,src.length-1);
        img.src = src;
    }else if(src=='none'){
        src = '';
    };*/
    if(img.src!=''){
        /*Set blur property*/
        /*var ratio = img.width / img.height;
        var blurQS = 'dir.blur-boundary>dir.blur';
        for(i=0;i<document.querySelectorAll(blurQS).length;i++){
            if(elementInTheport(document.querySelectorAll(blurQS)[i].parentElement)==true){
                document.querySelectorAll(blurQS)[i].style.backgroundImage=window.getComputedStyle(document.body).getPropertyValue('background-image');
                var ImgWidth=0;
                var ImgHeight=0;
                var ImgLeftPadding=0;
                var ImgTopPadding=0;
                if(document.querySelectorAll(blurQS)[i].offsetWidth/document.querySelectorAll(blurQS)[i].offsetHeight>ratio){
                    ImgWidth=document.body.clientWidth;
                    ImgHeight=ImgWidth/ratio;
                    ImgTopPadding=document.body.clientHeight-(ImgHeight-document.body.clientHeight)/2;
                    ImgLeftPadding=0;
                }else if(document.querySelectorAll(blurQS)[i].offsetWidth/document.querySelectorAll(blurQS)[i].offsetHeight==ratio){
                    ImgWidth=document.body.clientWidth;
                    ImgHeight=document.body.clientHeight;
                    ImgLeftPadding=0;
                    ImgTopPadding=0;
                }else if(document.querySelectorAll(blurQS)[i].offsetWidth/document.querySelectorAll(blurQS)[i].offsetHeight<ratio){
                    ImgHeight = document.body.clientHeight;
                    ImgWidth=ImgHeight*ratio;
                    ImgTopPadding=0;
                    ImgLeftPadding=document.body.clientWidth-(ImgWidth - document.body.clientWidth)/2;
                };
                document.querySelectorAll(blurQS)[i].style.left=(-document.body.clientWidth)+'px';
                document.querySelectorAll(blurQS)[i].style.top=(-document.body.clientHeight)+'px';
                document.querySelectorAll(blurQS)[i].style.width=(3*document.body.clientWidth)+'px';
                document.querySelectorAll(blurQS)[i].style.height=(3*document.body.clientHeight)+'px';
                document.querySelectorAll(blurQS)[i].style.backgroundSize=ImgWidth+'px '+ImgHeight+'px';
                document.querySelectorAll(blurQS)[i].style.backgroundPositionX=ImgLeftPadding+'px';
                document.querySelectorAll(blurQS)[i].style.backgroundPositionY=ImgTopPadding+'px';
                var ScrollLeft = document.body.scrollLeft;
                var ScrollTop = document.body.scrollTop;
                if(document.querySelectorAll(blurQS)[i].parentElement.classList.contains('fixed')==true){
                    ScrollLeft = 0;
                    ScrollTop = 0;
                };
                document.querySelectorAll(blurQS)[i].style.transform='translate('+(ScrollLeft-document.querySelectorAll(blurQS)[i].parentElement.offsetLeft)+'px,'+(ScrollTop-document.querySelectorAll(blurQS)[i].parentElement.offsetTop)+'px)';
            }else{
                document.querySelectorAll(blurQS)[i].removeAttribute('style');
            };
        };*/
    };
},1);
};