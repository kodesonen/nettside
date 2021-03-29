
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
if (img !== null) {
    img.onclick = function(){
      modal.style.display = "block";
      modalImg.src = this.src;
      captionText.innerHTML = this.alt;
    }
}

var span = document.getElementsByClassName("close")[0];
if (span !== null) {

    span.onclick = function() { 
      modal.style.display = "none";
    }
}

// ------------------------------ //
//     Type effect on homepage    //
// ------------------------------ //

// Write script that makes type effect on the promotion header section on the homepage

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