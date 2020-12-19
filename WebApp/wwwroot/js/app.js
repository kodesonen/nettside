
// ------------------------------ //
//     Responsive nav header      //
// ------------------------------ //

function openNav() {
  document.getElementById("navigation").style.width = "100%";
}

function closeNav() {
  document.getElementById("navigation").style.width = "0%";
}

// ------------------------------ //
// Image modal under Utfordringer //
// ------------------------------ //

var modal = document.getElementById('utfordringer-modal');

var img = document.getElementById('image-ufordringer-id');
var modalImg = document.getElementById("utfordringer_image");
var captionText = document.getElementById("caption");
img.onclick = function(){
  modal.style.display = "block";
  modalImg.src = this.src;
  captionText.innerHTML = this.alt;
}

var span = document.getElementsByClassName("close")[0];

span.onclick = function() { 
  modal.style.display = "none";
}

// ------------------------------ //
//     Type effect on homepage    //
// ------------------------------ //

/*
function typeWriter() {
  var i = 0;
  var txt = 'medlemmer.';
  var speed = 50;

  if(i < txt.length) {
    document.getElementById("type-effect").innerHTML += txt.charAt(i);
    i++;
    setTimeout(typerWriter, speed);
  }
}
*/