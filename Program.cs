using System;
using hs;

var messung = new Messung(100, 2, 100, 120);
var messung1 = new Messung(150, 1, 100, 158);

var messung2 = new Messung(200, 3, 100, 150);


var mm = new MessungManager();

mm.addMessung(messung);
mm.addMessung(messung1);
mm.addMessung(messung2);