using System;
using hs;

var messung = new Messung(100, 2);
var messung1 = new Messung(150, 1);

var messung2 = new Messung(200, 3);


var mm = new MessungManager();

mm.addMessung(messung);
mm.addMessung(messung1);
mm.addMessung(messung2);