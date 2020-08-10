$(document).ready(function() {
    
    $('.js--post-section').waypoint(function(direction){
        
        if(direction == "down"){
            $('nav').addClass('sticky');
        } else{
            $('nav').removeClass('sticky');
        }
        
    }, {
        offset: '60px;'
    });
    
    
 
});


