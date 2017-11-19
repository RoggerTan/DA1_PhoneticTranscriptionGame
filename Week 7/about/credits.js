(function (cjs, an) {

var p; // shortcut to reference prototypes
var lib={};var ss={};var img={};
lib.webFontTxtInst = {}; 
var loadedTypekitCount = 0;
var loadedGoogleCount = 0;
var gFontsUpdateCacheList = [];
var tFontsUpdateCacheList = [];
lib.ssMetadata = [];



lib.updateListCache = function (cacheList) {		
	for(var i = 0; i < cacheList.length; i++) {		
		if(cacheList[i].cacheCanvas)		
			cacheList[i].updateCache();		
	}		
};		

lib.addElementsToCache = function (textInst, cacheList) {		
	var cur = textInst;		
	while(cur != null && cur != exportRoot) {		
		if(cacheList.indexOf(cur) != -1)		
			break;		
		cur = cur.parent;		
	}		
	if(cur != exportRoot) {		
		var cur2 = textInst;		
		var index = cacheList.indexOf(cur);		
		while(cur2 != null && cur2 != cur) {		
			cacheList.splice(index, 0, cur2);		
			cur2 = cur2.parent;		
			index++;		
		}		
	}		
	else {		
		cur = textInst;		
		while(cur != null && cur != exportRoot) {		
			cacheList.push(cur);		
			cur = cur.parent;		
		}		
	}		
};		

lib.gfontAvailable = function(family, totalGoogleCount) {		
	lib.properties.webfonts[family] = true;		
	var txtInst = lib.webFontTxtInst && lib.webFontTxtInst[family] || [];		
	for(var f = 0; f < txtInst.length; ++f)		
		lib.addElementsToCache(txtInst[f], gFontsUpdateCacheList);		

	loadedGoogleCount++;		
	if(loadedGoogleCount == totalGoogleCount) {		
		lib.updateListCache(gFontsUpdateCacheList);		
	}		
};		

lib.tfontAvailable = function(family, totalTypekitCount) {		
	lib.properties.webfonts[family] = true;		
	var txtInst = lib.webFontTxtInst && lib.webFontTxtInst[family] || [];		
	for(var f = 0; f < txtInst.length; ++f)		
		lib.addElementsToCache(txtInst[f], tFontsUpdateCacheList);		

	loadedTypekitCount++;		
	if(loadedTypekitCount == totalTypekitCount) {		
		lib.updateListCache(tFontsUpdateCacheList);		
	}		
};
// symbols:
// helper functions:

function mc_symbol_clone() {
	var clone = this._cloneProps(new this.constructor(this.mode, this.startPosition, this.loop));
	clone.gotoAndStop(this.currentFrame);
	clone.paused = this.paused;
	clone.framerate = this.framerate;
	return clone;
}

function getMCSymbolPrototype(symbol, nominalBounds, frameBounds) {
	var prototype = cjs.extend(symbol, cjs.MovieClip);
	prototype.clone = mc_symbol_clone;
	prototype.nominalBounds = nominalBounds;
	prototype.frameBounds = frameBounds;
	return prototype;
	}


(lib.Symbol1 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Layer 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#000000").s().p("AgoBKIAAiTIATAAIAACDIA+AAIAAAQg");
	this.shape.setTransform(103.2,72.5);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#000000").s().p("AgsBLIgQgBIAAiRIATgDIAWgBQATAAAPAGQAPAEAKAJQAKAJAFAOQAGANAAARQAAARgGAPQgFAOgLALQgKAKgRAGQgPAFgWABIgTgBgAgfg6IgKABIAAB0IAJAAIAKABQAeAAAQgRQARgQAAgdQAAgSgHgMQgGgNgOgHQgNgHgTAAIgNABg");
	this.shape_1.setTransform(90.5,72.5);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#000000").s().p("AgUBLIgNgDQgHgCgEgDIAFgQQAHAEAJADQAIADALAAQANgBAIgGQAIgHAAgMQAAgKgGgHQgGgHgPgFQgSgGgKgKQgKgKAAgPQAAgMAFgJQAHgJAKgFQALgFANAAQALAAAJACQAIACAFADIgFAPIgLgEQgHgCgLgBQgIABgHADQgGADgDAFQgCAFAAAGQAAAKAHAGQAHAHAOAFQATAHAJAJQAKALAAAQQAAALgGAKQgFAKgMAFQgMAGgQAAIgOgBg");
	this.shape_2.setTransform(77.3,72.4);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#000000").s().p("AgUBEQgQgJgKgRQgJgQAAgZQAAgWAKgRQAJgSASgJQARgKAWAAQAOAAAJACQAJACADACIgEAQIgNgFQgIgBgJAAQgSAAgMAHQgNAHgHAOQgHANAAATQAAASAHANQAGAOANAHQAMAHASAAQAJAAAIgBIAOgFIAEAPQgFADgKACQgLACgNAAQgUAAgRgIg");
	this.shape_3.setTransform(65.6,72.4);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#000000").s().p("AgbBQQgLgHgHgMQgFgMAAgQQAAgQAFgNQAHgMAKgIQAMgHAPgBQAMABAJAEQAJAFAEAIQAFAHACAIQADAJgBAHIAAAGIgBAEIhJAAQAAANAFAIQAFAIAJAEQAHADAKAAQAJAAAIgBIAMgEIADAOQgFACgJACQgIACgNAAQgQAAgMgGgAgTgFQgFAFgEAHQgDAHgBAHIA3AAQABgHgCgHQgDgHgGgEQgFgFgLgBQgJABgHAEgAAKgkIgKgUIgBAAIgLAUIgOAAIATgfIAMAAIATAfgAATg4IAOgdIASAAIgVAdg");
	this.shape_4.setTransform(49.5,71.4);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#000000").s().p("AAVBOIgkgzIgKALIAAAoIgTAAIAAibIATAAIAABhIABAAIAFgFIAEgGIAfgkIAXAAIgoArIAuA+g");
	this.shape_5.setTransform(39.3,72.1);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#000000").s().p("AABBDQgEgCgEgDQgDgFgCgHQgCgHAAgJIAAg5IgQAAIAAgPIAQAAIAAgZIASgFIAAAeIAcAAIAAAPIgcAAIAAA4QAAAKADAFQAEAGAHAAIAHAAIAEgBIABAOIgGACIgKAAQgIAAgFgCg");
	this.shape_6.setTransform(24.8,73.1);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#000000").s().p("AgbBQQgLgHgHgMQgFgMgBgQQABgQAFgNQAGgMAMgIQALgHAQgBQALABAJAEQAIAFAGAIQAEAHACAIQACAJABAHIgBAGIAAAEIhKAAQAAANAFAIQAFAIAIAEQAJADAIAAQALAAAGgBIANgEIADAOQgFACgJACQgJACgNAAQgOAAgNgGgAgSgFQgGAFgEAHQgDAHgBAHIA4AAQAAgHgDgHQgCgHgFgEQgHgFgJgBQgKABgGAEgAAKgkIgKgUIAAAAIgMAUIgOAAIASgfIAOAAIATAfgAASg4IAQgdIASAAIgXAdg");
	this.shape_7.setTransform(16.3,71.4);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#000000").s().p("AgJBKIAAhpIATAAIAABpgAgHg1QgEgDAAgFQAAgFAEgEQADgDAFAAQAFAAADADQADAEAAAFQAAAFgDADQgDAEgGAAQgEAAgDgEg");
	this.shape_8.setTransform(7.7,72.4);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#000000").s().p("AAaBOIAAg9QAAgJgCgHQgDgGgFgEQgFgEgKgBQgIAAgHAGQgHAFgDAIIgBAEIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAGAEAIQADAIAAAOIAAA/g");
	this.shape_9.setTransform(-1,72.1);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#000000").s().p("AgJBKIAAiDIgtAAIAAgQIBtAAIAAAQIguAAIAACDg");
	this.shape_10.setTransform(-12.4,72.5);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#000000").s().p("AgaAfIAUgbIAAgBIggAEIAAgOIAgAFIAAgBIgUgbIANgIIANAfIABAAIAMgfIAOAIIgVAcIAhgFIAAAOIghgDIAAAAIAVAaIgOAIIgNgfIAAAAIgOAgg");
	this.shape_11.setTransform(-26.2,68.7);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#000000").s().p("AgbAzQgHgEgDgHQgEgHgBgIQABgTAQgJQARgLAeAAIAAgCIgCgKQgBgGgFgEQgGgEgJAAQgIAAgHACQgHACgGAEIgFgNQAHgEAJgDQAJgCAJgBQAQABAKAGQAIAGADAKQAEAKAAALIAAAnIABANIABAMIgSAAIgBgNIgBAAQgFAGgIAFQgJAEgKABQgLAAgHgFgAABAAQgJACgHAFQgHAGAAAKQABAJAEAFQAGAEAIAAQAJAAAHgFQAGgFACgIIABgDIAAgDIAAgRIgVAAg");
	this.shape_12.setTransform(117.6,46.1);

	this.shape_13 = new cjs.Shape();
	this.shape_13.graphics.f("#000000").s().p("AgHBHQgDgDAAgFQAAgFADgDQADgDAEAAQAEAAADADQADADABAFQgBAFgDADQgCADgFABQgEgBgDgDgAgaAeQgMgHgGgMQgHgLAAgRQAAgSAHgNQAHgMAMgHQAMgGANgBQAQABALAGQAMAHAGANQAHAMAAAQQgBATgHAMQgIANgMAGQgMAGgMAAQgOAAgMgHgAgSg1QgGAGgEAKQgEAJABAKQAAAMADAIQAFAJAHAGQAIAFAIAAQAJAAAHgFQAIgGAEgJQAEgIAAgMQAAgJgDgKQgDgJgIgHQgGgGgMAAQgKAAgIAGg");
	this.shape_13.setTransform(106.6,48);

	this.shape_14 = new cjs.Shape();
	this.shape_14.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIAAgHAGQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAAOIAAA/g");
	this.shape_14.setTransform(94.4,43.6);

	this.shape_15 = new cjs.Shape();
	this.shape_15.graphics.f("#000000").s().p("AgaBPQgLgGgHgMQgHgMAAgRQAAgTAHgMQAHgMAMgGQAMgHAOAAQAPAAAMAHQALAHAHALQAGAMAAARQAAAUgIAMQgIANgMAFQgMAHgMAAQgPAAgLgIgAgRgDQgIAFgDAKQgDAIgBALQAAAMAFAJQAEAJAHAGQAHAFAJAAQAJAAAIgFQAGgGAFgJQAEgJAAgMQAAgJgDgKQgEgKgGgFQgIgGgLgBQgKABgHAGgAAMgkIgLgUIAAAAIgKAUIgPAAIATgfIANAAIATAfgAAeg4IgUgdIARAAIAOAdg");
	this.shape_15.setTransform(77.6,43);

	this.shape_16 = new cjs.Shape();
	this.shape_16.graphics.f("#000000").s().p("AgjBIQgKgGgGgNQgGgMAAgQQAAgSAGgLQAHgNAKgHQALgHANAAQAMAAAIAFQAIAEADAHIABAAIAAgdIgqAAIAAgMIAqAAIAAgWIATAAIAAAWIARAAIAAAMIgRAAIAABdIAAAPIABANIgRAAIgBgTIgBAAQgEAJgJAGQgKAGgMAAQgNAAgKgHgAgXgLQgHAGgEAIQgEAJAAAMQAAALAEAJQADAJAHAFQAHAFALABQAJgBAHgGQAIgGADgLIABgEIAAgEIAAgSIAAgEIgBgEQgCgJgIgGQgHgHgKAAQgKAAgHAFg");
	this.shape_16.setTransform(65.8,43.7);

	this.shape_17 = new cjs.Shape();
	this.shape_17.graphics.f("#000000").s().p("AgbBQQgLgHgHgMQgFgMAAgQQAAgQAFgNQAHgMAKgIQAMgHAPgBQAMABAJAEQAJAFAEAIQAFAHACAIQADAJgBAHIAAAGIgBAEIhJAAQAAANAFAIQAFAIAJAEQAHADAKAAQAJAAAIgBIAMgEIADAOQgFACgJACQgIACgNAAQgQAAgMgGgAgTgFQgFAFgEAHQgDAHgBAHIA3AAQABgHgCgHQgDgHgGgEQgFgFgLgBQgJABgHAEgAAKgkIgKgUIgBAAIgLAUIgOAAIATgfIAMAAIATAfgAATg4IAOgdIASAAIgVAdg");
	this.shape_17.setTransform(49.5,43);

	this.shape_18 = new cjs.Shape();
	this.shape_18.graphics.f("#000000").s().p("AAVBOIgkgzIgKALIAAAoIgTAAIAAibIATAAIAABhIABAAIAFgFIAEgGIAfgkIAXAAIgoArIAuA+g");
	this.shape_18.setTransform(39.3,43.6);

	this.shape_19 = new cjs.Shape();
	this.shape_19.graphics.f("#000000").s().p("AABBDQgEgBgEgFQgDgEgCgHQgCgHAAgJIAAg5IgQAAIAAgPIAQAAIAAgaIASgEIAAAeIAcAAIAAAPIgcAAIAAA4QAAAKADAFQAEAGAHAAIAHAAIAEgCIABAPIgGACIgKAAQgIAAgFgCg");
	this.shape_19.setTransform(24.8,44.7);

	this.shape_20 = new cjs.Shape();
	this.shape_20.graphics.f("#000000").s().p("AgbBQQgLgHgHgMQgFgMgBgQQABgQAFgNQAGgMAMgIQALgHAQgBQALABAJAEQAIAFAGAIQAEAHACAIQACAJABAHIgBAGIAAAEIhKAAQAAANAFAIQAFAIAIAEQAJADAIAAQALAAAGgBIANgEIADAOQgFACgJACQgJACgNAAQgOAAgNgGgAgSgFQgGAFgEAHQgDAHgBAHIA4AAQAAgHgDgHQgCgHgFgEQgHgFgJgBQgKABgGAEgAAKgkIgKgUIAAAAIgMAUIgOAAIASgfIAOAAIATAfgAASg4IAQgdIASAAIgXAdg");
	this.shape_20.setTransform(16.3,43);

	this.shape_21 = new cjs.Shape();
	this.shape_21.graphics.f("#000000").s().p("AgJBKIAAhpIATAAIAABpgAgHg1QgEgDAAgFQAAgFAEgEQADgDAFAAQAFAAADADQADAEAAAFQAAAFgDADQgDAEgGAAQgEAAgDgEg");
	this.shape_21.setTransform(7.7,44);

	this.shape_22 = new cjs.Shape();
	this.shape_22.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIAAgHAGQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAAOIAAA/g");
	this.shape_22.setTransform(-1,43.6);

	this.shape_23 = new cjs.Shape();
	this.shape_23.graphics.f("#000000").s().p("AgJBKIAAiDIgtAAIAAgQIBtAAIAAAQIguAAIAACDg");
	this.shape_23.setTransform(-12.4,44);

	this.shape_24 = new cjs.Shape();
	this.shape_24.graphics.f("#000000").s().p("AgaAfIAUgbIAAgBIggAFIAAgPIAgAFIAAgBIgUgbIANgHIANAeIABAAIAMgeIAOAHIgVAcIAhgFIAAAPIghgEIAAAAIAVAaIgOAIIgNgeIAAAAIgOAeg");
	this.shape_24.setTransform(-26.2,40.2);

	this.shape_25 = new cjs.Shape();
	this.shape_25.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIABgHAFQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAANIAABAg");
	this.shape_25.setTransform(245,15.2);

	this.shape_26 = new cjs.Shape();
	this.shape_26.graphics.f("#000000").s().p("AAbA2IAAg8QAAgIgDgIQgCgGgGgFQgFgEgJAAQgJAAgHAFQgGAGgDAJIgBAEIAAAFIAAA+IgUAAIAAhMIAAgPIAAgOIAQAAIACASIAAAAQACgGAFgEQAFgFAIgDQAGgCAIAAQAGAAAGABQAHADAFAFQAGAFAEAIQAEAJAAAOIAAA+g");
	this.shape_26.setTransform(232.8,17.5);

	this.shape_27 = new cjs.Shape();
	this.shape_27.graphics.f("#000000").s().p("AgSBMIAAhpIASAAIAABpgAgTgsIATgfIAUAAIgaAfg");
	this.shape_27.setTransform(225,15.3);

	this.shape_28 = new cjs.Shape();
	this.shape_28.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIABgHAFQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAANIAABAg");
	this.shape_28.setTransform(215.4,15.2);

	this.shape_29 = new cjs.Shape();
	this.shape_29.graphics.f("#000000").s().p("AgQAxQgMgHgGgMQgHgNAAgQQAAgPAHgNQAHgNAMgHQAOgHAQAAQAJAAAHABIALAEIgEAPIgJgDQgGgCgIAAQgMAAgIAFQgIAGgEAJQgFAJAAAKQAAANAGAJQAEAIAIAFQAIAFAKAAIAPgCIAJgDIADAOIgMAEQgIACgKAAQgQAAgLgGg");
	this.shape_29.setTransform(204.5,17.6);

	this.shape_30 = new cjs.Shape();
	this.shape_30.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIABgHAFQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAANIAABAg");
	this.shape_30.setTransform(188.7,15.2);

	this.shape_31 = new cjs.Shape();
	this.shape_31.graphics.f("#000000").s().p("AAbA2IAAg8QAAgIgDgIQgCgGgGgFQgFgEgJAAQgJAAgHAFQgGAGgDAJIgBAEIAAAFIAAA+IgUAAIAAhMIAAgPIAAgOIAQAAIACASIAAAAQACgGAFgEQAFgFAIgDQAGgCAIAAQAGAAAGABQAHADAFAFQAGAFAEAIQAEAJAAAOIAAA+g");
	this.shape_31.setTransform(176.5,17.5);

	this.shape_32 = new cjs.Shape();
	this.shape_32.graphics.f("#000000").s().p("AABBMIAAhpIAUAAIAABpgAAGgsIgagfIAVAAIATAfg");
	this.shape_32.setTransform(166.7,15.3);

	this.shape_33 = new cjs.Shape();
	this.shape_33.graphics.f("#000000").s().p("AgZA2IAAhIIAAgRIgBgQIARAAIABAVIAAAAQAFgLAHgGQAHgGAKAAIADAAIACAAIAAASIgCAAIgEAAQgKAAgHAHQgGAHgCALIgBAEIAAAFIAAA3g");
	this.shape_33.setTransform(162.2,17.5);

	this.shape_34 = new cjs.Shape();
	this.shape_34.graphics.f("#000000").s().p("AABBDQgEgBgEgFQgEgEgCgHQgBgHAAgJIAAg5IgRAAIAAgPIARAAIAAgaIASgEIAAAeIAbAAIAAAPIgbAAIAAA4QAAAKADAGQADAFAJAAIAGgBIAEgBIABAPIgHACIgKAAQgGAAgGgCg");
	this.shape_34.setTransform(154.2,16.2);

	this.shape_35 = new cjs.Shape();
	this.shape_35.graphics.f("#000000").s().p("AgXBLQgJgCgIgFIAGgOQAEADAJADQAHACALAAQAIAAAIgEQAIgDAEgIQAFgIAAgOIAAgMIAAAAQgFAIgJAFQgIAFgLAAQgNAAgLgHQgKgHgFgMQgHgKABgPQgBgSAIgMQAGgNALgGQALgIAMABQAIAAAHACQAGADAFAFIAGAIIABAAIABgQIAQAAIAAANIAAAQIAAA9QAAASgEAMQgDAMgJAHQgHAHgLADQgKACgJAAQgKABgJgDgAgUgyQgJAKAAATQAAALAEAIQADAIAHAFQAHAFAKAAQAIAAAHgFQAIgFAEgJIABgEIAAgGIAAgTIAAgFIgBgEQgDgIgHgGQgHgGgKAAQgOAAgIALg");
	this.shape_35.setTransform(139.5,19.8);

	this.shape_36 = new cjs.Shape();
	this.shape_36.graphics.f("#000000").s().p("AAaA2IAAg8QABgIgDgIQgDgGgFgFQgFgEgKAAQgIAAgHAFQgGAGgDAJIgBAEIgBAFIAAA+IgTAAIAAhMIAAgPIgBgOIARAAIABASIABAAQADgGAEgEQAFgFAHgDQAHgCAIAAQAGAAAGABQAGADAHAFQAFAFAEAIQAEAJgBAOIAAA+g");
	this.shape_36.setTransform(127.6,17.5);

	this.shape_37 = new cjs.Shape();
	this.shape_37.graphics.f("#000000").s().p("AgfA4QgLgGgHgMQgHgMAAgRQAAgSAHgMQAHgNAMgGQAMgHAPAAIAIABIAJACIAJADIAKADQAEAAACgDQADgCAAgEIgBgHIgDgGIAPgCQACADAAAEQACAEAAAEQAAAJgGAGQgFAFgKAAQAFAGADAJQADAJAAAKQAAATgIANQgIAMgMAGQgMAHgMAAQgOAAgMgIgAgWgaQgHAGgEAJQgDAJAAAKQAAAMAEAJQAEAJAHAGQAHAFAKAAQAIAAAIgFQAHgGAEgJQAEgKAAgLQAAgIgDgKQgDgJgHgHQgHgGgLgBQgLABgHAGg");
	this.shape_37.setTransform(115.9,16.9);

	this.shape_38 = new cjs.Shape();
	this.shape_38.graphics.f("#000000").s().p("AgjA+QgIgEgGgKQgFgKAAgTIAAg9IATAAIAAA6QAAAQAFAJQAGAJANAAQAGAAAFgDQAEgCAEgEQAEgEABgFIACgEIAAgFIAAhBIAPAAQAGAAACgCQADgCAAgEIgCgHIgCgGIAOgCIADAHIABAIQAAAJgFAFQgFAEgIABIgDAAIAABCIABAPIAAAOIgRAAIgBgSIAAAAQgDAFgFAEQgEAFgGADQgHADgKAAQgIAAgJgEg");
	this.shape_38.setTransform(104.3,16.6);

	this.shape_39 = new cjs.Shape();
	this.shape_39.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIABgHAFQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAANIAABAg");
	this.shape_39.setTransform(91.2,15.2);

	this.shape_40 = new cjs.Shape();
	this.shape_40.graphics.f("#000000").s().p("AgQAxQgMgHgHgMQgGgNAAgQQAAgPAHgNQAHgNAMgHQANgHARAAQAJAAAHABIALAEIgFAPIgJgDQgFgCgIAAQgMAAgHAFQgJAGgFAJQgDAJAAAKQAAANAEAJQAFAIAJAFQAGAFAMAAIANgCIAKgDIAEAOIgNAEQgHACgLAAQgPAAgMgGg");
	this.shape_40.setTransform(80.3,17.6);

	this.shape_41 = new cjs.Shape();
	this.shape_41.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIABgHAFQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAANIAABAg");
	this.shape_41.setTransform(64.5,15.2);

	this.shape_42 = new cjs.Shape();
	this.shape_42.graphics.f("#000000").s().p("AgQAxQgMgHgGgMQgHgNAAgQQAAgPAHgNQAHgNANgHQAMgHARAAQAIAAAIABIALAEIgEAPIgJgDQgGgCgIAAQgMAAgHAFQgJAGgFAJQgDAJgBAKQAAANAGAJQAEAIAIAFQAIAFAKAAIAPgCIAJgDIADAOIgLAEQgJACgKAAQgPAAgMgGg");
	this.shape_42.setTransform(53.6,17.6);

	this.shape_43 = new cjs.Shape();
	this.shape_43.graphics.f("#000000").s().p("AgbBJQgHgFgDgGQgEgIgBgHQABgUAQgKQARgKAeAAIAAgCIgCgJQgBgGgFgEQgGgEgJAAQgIAAgHABQgHADgGAEIgFgOQAHgEAJgCQAJgCAJgBQAQABAKAFQAIAHADAKQAEAKAAAJIAAApIABANIABAMIgSAAIgBgNIgBAAQgFAGgIAEQgJAFgKABQgLgBgHgEgAABAWQgJACgHAFQgHAFAAAKQABAKAEAFQAGAEAIAAQAJAAAHgFQAGgGACgHIABgDIAAgDIAAgTIgVACgAgIgtIASgfIAWAAIgbAfg");
	this.shape_43.setTransform(42.9,15.5);

	this.shape_44 = new cjs.Shape();
	this.shape_44.graphics.f("#000000").s().p("AgZA2IAAhIIAAgRIgBgQIARAAIABAVIAAAAQAFgLAHgGQAIgGAJAAIADAAIACAAIAAASIgDAAIgDAAQgKAAgHAHQgGAHgCALIAAAEIgBAFIAAA3g");
	this.shape_44.setTransform(35,17.5);

	this.shape_45 = new cjs.Shape();
	this.shape_45.graphics.f("#000000").s().p("AABBDQgEgBgEgFQgDgEgCgHQgCgHAAgJIAAg5IgQAAIAAgPIAQAAIAAgaIASgEIAAAeIAcAAIAAAPIgcAAIAAA4QAAAKADAGQAEAFAHAAIAHgBIAEgBIABAPIgGACIgKAAQgIAAgFgCg");
	this.shape_45.setTransform(27.1,16.2);

	this.shape_46 = new cjs.Shape();
	this.shape_46.graphics.f("#000000").s().p("AgHBGQgDgDAAgFQAAgFADgDQADgEAEAAQAFAAADAEQADADAAAFQAAAFgDADQgDADgFABQgEgBgDgDgAgZAfQgIgDgGgKQgFgLAAgRIAAg+IATAAIAAA6QAAAPAFAJQAGAJANABQAFgBAFgCQAFgDAEgEQAEgEABgFIACgDIAAgFIAAhBIATAAIAABMIABAQIAAANIgRAAIgBgRIAAAAQgDAEgFAFQgEAEgHADQgHADgJABQgIAAgJgFg");
	this.shape_46.setTransform(12.8,19.7);

	this.shape_47 = new cjs.Shape();
	this.shape_47.graphics.f("#000000").s().p("AAaBOIAAg9QAAgIgCgIQgDgGgFgEQgFgFgKAAQgIABgHAFQgHAGgDAGIgBAFIAAAFIAABAIgTAAIAAibIATAAIAABDIABAAQACgFAEgDQADgEAEgDIAKgDQAEgCAFAAQAGAAAGACQAHACAFAFQAGAFAEAJQADAIAAANIAABAg");
	this.shape_47.setTransform(0.7,15.2);

	this.shape_48 = new cjs.Shape();
	this.shape_48.graphics.f("#000000").s().p("AgtBLIAAiSIARgCIAUgBQANAAALAEQAKADAHAGQAFAFAEAIQADAIAAAKQAAAKgCAIQgDAIgGAEQgHAIgMAFQgMAEgNAAIgIgBIgIgBIAAA8gAgSg6IgIABIAAA5IAIABIAIAAQARAAAKgHQAJgIAAgPQAAgPgJgHQgJgHgQAAIgKAAg");
	this.shape_48.setTransform(-10.7,15.5);

	this.shape_49 = new cjs.Shape();
	this.shape_49.graphics.f("#000000").s().p("AgaAeIAUgbIAAAAIggAFIAAgPIAgAFIAAgBIgUgbIANgHIANAeIABAAIAMgeIAOAHIgVAcIAhgFIAAAPIghgFIAAABIAVAaIgOAIIgNgeIAAAAIgOAeg");
	this.shape_49.setTransform(-26.2,11.8);

	this.shape_50 = new cjs.Shape();
	this.shape_50.graphics.f("#000000").s().p("AAfBAIAAhHQAAgKgCgJQgEgIgFgFQgHgFgLAAQgLAAgHAHQgIAGgEAKIgBAFIAAAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIACAVIAAAAQADgGAGgFQAGgFAIgEQAIgDAKAAQAGAAAIACQAHACAIAGQAGAGAFALQAEAKAAAQIAABKg");
	this.shape_50.setTransform(471.2,53.1);

	this.shape_51 = new cjs.Shape();
	this.shape_51.graphics.f("#000000").s().p("AggBWQgIgFgFgIQgEgJAAgJQAAgWATgNQAUgMAkABIAAgDQAAgFgCgHQgCgGgGgFQgGgFgMAAQgJAAgJADQgIABgHAFIgFgPQAIgFALgDQAKgDALAAQATAAALAHQAKAIAEAMQAEAMAAALIAAAvIABAQIABAPIgVAAIgBgQIgBAAQgGAHgJAFQgKAGgNAAQgMAAgJgFgAABAaQgLACgIAHQgIAFAAANQAAAKAGAGQAGAFAJAAQAMAAAHgGQAIgHADgHIABgEIAAgEIAAgVIgFgBQgKAAgKACgAARg1IgPgZIAAAAIgOAZIgRAAIAYglIAPAAIAZAlg");
	this.shape_51.setTransform(457.3,50.7);

	this.shape_52 = new cjs.Shape();
	this.shape_52.graphics.f("#000000").s().p("AgLBYIAAicIg1AAIAAgTICBAAIAAATIg2AAIAACcg");
	this.shape_52.setTransform(446.6,50.8);

	this.shape_53 = new cjs.Shape();
	this.shape_53.graphics.f("#000000").s().p("AAeBcIAAhIQABgKgDgJQgDgHgGgFQgGgFgLAAQgLAAgHAGQgJAHgDAJIgCAEIAAAGIAABMIgWAAIAAi3IAWAAIAABOIABAAQACgFAFgEQAEgEAFgDIALgFQAFgBAHAAQAGAAAHACQAIACAHAGQAGAGAFALQAFAJAAAQIAABLg");
	this.shape_53.setTransform(428.5,50.3);

	this.shape_54 = new cjs.Shape();
	this.shape_54.graphics.f("#000000").s().p("AAfBAIAAhHQAAgKgCgJQgEgIgFgFQgHgFgLAAQgLAAgHAHQgIAGgEAKIgBAFIAAAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIACAVIAAAAQADgGAGgFQAGgFAIgEQAIgDAKAAQAGAAAIACQAHACAIAGQAGAGAEALQAFAKAAAQIAABKg");
	this.shape_54.setTransform(414,53.1);

	this.shape_55 = new cjs.Shape();
	this.shape_55.graphics.f("#000000").s().p("AgKBYIAAh9IAWAAIAAB9gAgJg+QgEgEAAgGQAAgHAEgEQAEgEAFAAQAHAAADAEQAEAEAAAHQAAAGgEAEQgDADgHABQgGgBgDgDg");
	this.shape_55.setTransform(403.7,50.8);

	this.shape_56 = new cjs.Shape();
	this.shape_56.graphics.f("#000000").s().p("ABEBYIgFhOIgCgYIAAgaIAAgYIgBAAIgKAgIgNAhIgeBWIgRAAIgchUIgLgjIgJggIAAAAIgBAYIgCAaIgBAaIgFBMIgWAAIANivIAdAAIAdBVIAKAeIAIAcIAAAAIAIgcIAKgeIAghVIAcAAIALCvg");
	this.shape_56.setTransform(390,50.8);

	this.shape_57 = new cjs.Shape();
	this.shape_57.graphics.f("#000000").s().p("AgaBTQgNgIgIgOQgIgOABgTQAAgTAGgOQAIgQANgJQANgJARAAQAPAAALAGQAKAGAGAJQAGAJACAJQACAKAAAJIAAAHIAAAEIhYAAQAAAPAHAKQAFAKAKAEQAKAFALAAQALAAAIgCIAPgFIAEARIgRAFQgKACgPAAQgSAAgOgIgAAiAOQAAgIgDgIQgDgIgHgGQgGgGgOAAQgKAAgHAGQgIAFgDAJQgFAHgBAJIBDAAIAAAAgAASg1IgPgZIgBAAIgOAZIgRAAIAZglIAOAAIAaAlg");
	this.shape_57.setTransform(367.5,50.7);

	this.shape_58 = new cjs.Shape();
	this.shape_58.graphics.f("#000000").s().p("AgwBYIAAivIAXAAIAACcIBKAAIAAATg");
	this.shape_58.setTransform(355.9,50.8);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_58},{t:this.shape_57},{t:this.shape_56},{t:this.shape_55},{t:this.shape_54},{t:this.shape_53},{t:this.shape_52},{t:this.shape_51},{t:this.shape_50},{t:this.shape_49},{t:this.shape_48},{t:this.shape_47},{t:this.shape_46},{t:this.shape_45},{t:this.shape_44},{t:this.shape_43},{t:this.shape_42},{t:this.shape_41},{t:this.shape_40},{t:this.shape_39},{t:this.shape_38},{t:this.shape_37},{t:this.shape_36},{t:this.shape_35},{t:this.shape_34},{t:this.shape_33},{t:this.shape_32},{t:this.shape_31},{t:this.shape_30},{t:this.shape_29},{t:this.shape_28},{t:this.shape_27},{t:this.shape_26},{t:this.shape_25},{t:this.shape_24},{t:this.shape_23},{t:this.shape_22},{t:this.shape_21},{t:this.shape_20},{t:this.shape_19},{t:this.shape_18},{t:this.shape_17},{t:this.shape_16},{t:this.shape_15},{t:this.shape_14},{t:this.shape_13},{t:this.shape_12},{t:this.shape_11},{t:this.shape_10},{t:this.shape_9},{t:this.shape_8},{t:this.shape_7},{t:this.shape_6},{t:this.shape_5},{t:this.shape_4},{t:this.shape_3},{t:this.shape_2},{t:this.shape_1},{t:this.shape}]}).wait(1));

}).prototype = getMCSymbolPrototype(lib.Symbol1, new cjs.Rectangle(-32.8,0,513.2,87.4), null);


// stage content:
(lib.credits = function(mode,startPosition,loop) {
if (loop == null) { loop = false; }	this.initialize(mode,startPosition,loop,{});

	// Layer 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#0066CC").s().p("AgfBUQgNgIgJgPQgHgPgBgUQAAgUAJgPQAIgOAOgIQAOgIAQAAQATAAAOAIQANAJAHANQAIAOAAATQAAAYgJAOQgKAPgOAIQgOAGgPAAQgQAAgOgHgAgVgOQgIAGgFALQgDAKgBANQAAAOAGALQAEALAJAGQAIAGALAAQALAAAIgGQAJgGAFgLQAFgMAAgOQAAgLgEgKQgEgKgIgIQgIgHgOgBQgMAAgJAIgAgNg2IAWglIAZAAIgfAlg");
	this.shape.setTransform(505.6,44.4);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#0066CC").s().p("AgTA5QgOgIgIgOQgIgPABgSQgBgTAJgPQAIgPAPgJQAPgIAUgBIASADQAJABAFADIgGASIgKgEQgHgCgJAAQgOAAgKAGQgJAHgFAKQgGALAAANQABAOAFAKQAGALAKAFQAIAHANAAQAKAAAHgCIALgFIAEARIgOAFQgJACgNABQgSAAgOgJg");
	this.shape_1.setTransform(492.9,46.9);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#0066CC").s().p("AgcBYQgLgCgIgFIAGgRQAGADAKADQAJAEAMAAQALAAAJgFQAJgFAFgJQAFgKAAgPIAAgPIAAAAQgGAJgKAHQgKAFgNABQgQgBgMgHQgMgJgHgOQgHgMAAgSQAAgVAIgPQAIgPANgIQANgHAPgBQAKAAAHAEQAIADAFAFQAFAFADAFIABAAIABgTIAUAAIgBAPIAAAUIAABIQAAAWgFAOQgEANgJAIQgKAJgMADQgMAEgLAAQgMAAgLgEgAgYg8QgKANgBAWQAAAMAEAKQAFAKAIAGQAIAGALAAQALAAAJgGQAIgGAEgLIACgGIAAgFIAAgXIAAgFIgBgGQgDgJgJgIQgIgGgMgBQgQAAgKANg");
	this.shape_2.setTransform(473.8,49.5);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#0066CC").s().p("AAfBAIAAhHQABgKgDgJQgEgIgFgFQgHgFgLAAQgKAAgIAHQgJAGgCAKIgCAFIAAAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIABAVIABAAQADgGAGgFQAGgFAIgEQAIgDAKAAQAGAAAIACQAHACAIAGQAGAGAEALQAFAKAAAQIAABKg");
	this.shape_3.setTransform(459.7,46.8);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#0066CC").s().p("AgfBUQgOgIgHgPQgJgPAAgUQABgUAIgPQAIgOAOgIQAOgIARAAQASAAANAIQAOAJAIANQAHAOABATQgBAYgJAOQgKAPgOAIQgOAGgOAAQgSAAgNgHgAgVgOQgJAGgEALQgDAKAAANQAAAOAEALQAFALAJAGQAJAGAKAAQALAAAIgGQAJgGAFgLQAFgMAAgOQAAgLgEgKQgEgKgIgIQgJgHgNgBQgMAAgJAIgAAPg2IgPgYIAAAAIgPAYIgRAAIAZglIAPAAIAYAlg");
	this.shape_4.setTransform(445.4,44.4);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#0066CC").s().p("AAfBcIAAhIQAAgKgDgJQgDgHgGgFQgHgFgKAAQgKAAgJAGQgIAHgDAJIgCAEIAAAGIAABMIgXAAIAAi3IAXAAIAABOIABAAQADgFAEgEQAEgEAGgDIAKgFQAFgBAGAAQAHAAAIACQAHACAHAGQAHAGAEALQAFAJgBAQIAABLg");
	this.shape_5.setTransform(431,44);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#0066CC").s().p("AAZBcIgqg8IgMANIAAAvIgXAAIAAi3IAXAAIAABzIAAAAIAGgHIAGgHIAkgrIAbAAIgwAzIA3BKg");
	this.shape_6.setTransform(418.3,44);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#0066CC").s().p("AgdA8QgKgFgHgMQgGgMgBgWIAAhJIAXAAIAABGQAAARAGALQAHALAPAAQAHAAAGgDQAGgDAEgFIAHgJIABgGIABgGIAAhNIAXAAIAABbIAAASIABAQIgVAAIgBgUIgBAAQgCAFgGAGQgGAFgIADQgIAEgKAAQgKABgKgFg");
	this.shape_7.setTransform(398.4,47.1);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#0066CC").s().p("AggBeQgNgIgHgOQgIgPAAgTQAAgSAHgPQAHgPAOgJQANgJASAAQAOAAAKAGQALAFAGAKQAFAIADAKQACAKAAAJIgBAGIAAAFIhYAAQABAPAGAJQAGALAKAEQAJAFALgBQAMAAAIgCIAPgEIADARIgQAEQgLADgOAAQgTAAgOgIgAAcAZQAAgIgDgJQgDgIgGgGQgHgFgMAAQgMAAgHAFQgHAGgEAIQgEAIgBAJIBCAAIAAAAgAAMgrIgNgYIAAAAIgNAYIgRAAIAWglIAPAAIAXAlgAAWhCIASgjIAVAAIgaAjg");
	this.shape_8.setTransform(385.3,43.3);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#0066CC").s().p("AAfBAIAAhHQABgKgEgJQgCgIgHgFQgGgFgLAAQgKAAgJAHQgHAGgDAKIgBAFIgBAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIACAVIAAAAQADgGAGgFQAGgFAIgEQAIgDAJAAQAIAAAHACQAIACAGAGQAHAGAFALQAEAKAAAQIAABKg");
	this.shape_9.setTransform(371,46.8);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#0066CC").s().p("AAeBcIAAhIQABgKgDgJQgDgHgGgFQgHgFgLAAQgKAAgIAGQgIAHgDAJIgBAEIAAAGIAABMIgYAAIAAi3IAYAAIAABOIAAAAQACgFAFgEQAEgEAGgDIALgFQAEgBAGAAQAHAAAIACQAHACAHAGQAGAGAFALQAEAJAAAQIAABLg");
	this.shape_10.setTransform(351.1,44);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#0066CC").s().p("AAfBAIAAhHQAAgKgDgJQgCgIgHgFQgGgFgLAAQgKAAgJAHQgIAGgCAKIgBAFIgBAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIABAVIABAAQADgGAGgFQAGgFAIgEQAIgDAKAAQAHAAAHACQAIACAGAGQAHAGAEALQAFAKAAAQIAABKg");
	this.shape_11.setTransform(336.6,46.8);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#0066CC").s().p("AggBWQgIgFgFgJQgEgHAAgKQAAgXATgLQAUgMAkgBIAAgCQAAgGgCgFQgCgHgGgFQgGgFgMAAQgJAAgJACQgIADgHAEIgFgPQAIgFALgDQAKgDALAAQATAAALAIQAKAHAEAMQAEAMAAAMIAAAvIABAQIABANIgVAAIgBgQIgBAAQgGAIgJAGQgKAFgNAAQgMAAgJgFgAABAaQgLACgIAGQgIAHAAALQAAAMAGAFQAGAGAJAAQAMgBAHgGQAIgGADgJIABgDIAAgEIAAgWIgFAAQgKAAgKACgAgCg2IgfglIAZAAIAVAlg");
	this.shape_12.setTransform(322.7,44.4);

	this.shape_13 = new cjs.Shape();
	this.shape_13.graphics.f("#0066CC").s().p("AAfBcIAAhIQAAgKgDgJQgDgHgGgFQgHgFgKAAQgLAAgHAGQgJAHgDAJIgCAEIAAAGIAABMIgWAAIAAi3IAWAAIAABOIABAAQADgFAEgEQAEgEAFgDIALgFQAFgBAHAAQAGAAAHACQAIACAHAGQAHAGAEALQAFAJgBAQIAABLg");
	this.shape_13.setTransform(309.6,44);

	this.shape_14 = new cjs.Shape();
	this.shape_14.graphics.f("#0066CC").s().p("AABBQQgFgDgEgEQgFgFgCgJQgCgIAAgLIAAhEIgTAAIAAgRIATAAIAAgeIAWgGIAAAkIAgAAIAAARIggAAIAABDQAAAMADAGQAFAHAIAAIAIgBIAGgBIABARIgJACIgLABQgIAAgHgCg");
	this.shape_14.setTransform(298,45.2);

	this.shape_15 = new cjs.Shape();
	this.shape_15.graphics.f("#0066CC").s().p("AAfBAIAAhHQABgKgDgJQgEgIgFgFQgHgFgLAAQgKAAgIAHQgJAGgCAKIgCAFIAAAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIABAVIABAAQADgGAGgFQAGgFAIgEQAIgDAKAAQAGAAAIACQAHACAIAGQAGAGAEALQAFAKAAAQIAABKg");
	this.shape_15.setTransform(281,46.8);

	this.shape_16 = new cjs.Shape();
	this.shape_16.graphics.f("#0066CC").s().p("AggBWQgIgFgFgJQgEgHAAgKQAAgXATgLQAUgMAkgBIAAgCQAAgGgCgFQgCgHgGgFQgGgFgMAAQgJAAgJACQgIADgHAEIgFgPQAIgFALgDQAKgDALAAQATAAALAIQAKAHAEAMQAEAMAAAMIAAAvIABAQIABANIgVAAIgBgQIgBAAQgGAIgJAGQgKAFgNAAQgMAAgJgFgAABAaQgLACgIAGQgIAHAAALQAAAMAGAFQAGAGAJAAQAMgBAHgGQAIgGADgJIABgDIAAgEIAAgWIgFAAQgKAAgKACgAgCg2IgfglIAZAAIAVAlg");
	this.shape_16.setTransform(267.2,44.4);

	this.shape_17 = new cjs.Shape();
	this.shape_17.graphics.f("#0066CC").s().p("AgfA6QgOgIgIgPQgHgOAAgUQgBgUAJgPQAIgPAOgIQAOgIAQAAQATAAANAIQAOAJAHAOQAIAOAAAUQAAAWgJAPQgJAPgOAHQgPAHgPAAQgRgBgNgHgAgVgoQgIAHgEALQgFALAAALQAAAOAGALQAEALAJAGQAJAGAKAAQALAAAJgGQAIgGAFgLQAFgLAAgOQAAgKgEgLQgEgLgIgIQgIgHgOgBQgMABgJAHg");
	this.shape_17.setTransform(254.2,46.9);

	this.shape_18 = new cjs.Shape();
	this.shape_18.graphics.f("#0066CC").s().p("AAeBcIAAhIQABgKgDgJQgDgHgGgFQgHgFgLAAQgJAAgIAGQgJAHgDAJIgBAEIAAAGIAABMIgYAAIAAi3IAYAAIAABOIAAAAQADgFAEgEQAEgEAFgDIAMgFQAEgBAGAAQAHAAAIACQAHACAHAGQAHAGAEALQAEAJABAQIAABLg");
	this.shape_18.setTransform(239.8,44);

	this.shape_19 = new cjs.Shape();
	this.shape_19.graphics.f("#0066CC").s().p("AgbBiQgOgIgHgNQgIgPAAgTQAAgTAHgPQAHgPAOgJQANgIARgBQAPABALAGQAKAFAGAKQAFAHADALQACAKAAAJIAAAGIgBAEIhXAAQAAAQAGAJQAGAKAKAEQAJAFALAAQAMAAAIgCIAPgFIAEARIgRAFQgKACgPABQgSAAgOgJgAAgAdQAAgIgCgJQgDgIgHgFQgHgGgNAAQgKAAgIAGQgHAFgEAIQgEAJgBAIIBCAAIAAAAgAAOgmIgNgYIgBAAIgMAYIgRAAIAWglIAQAAIAWAlgAAbg/QADgGADgDIAFgGQADgCAAgEQAAgEgDgCQgCgDgEAAQgEAAgDADIgFAHIgJgGQAEgGAFgFQAGgFAKgBQAJABAGAFQAFAGABAHQgBAGgDAEQgCAEgFADQgEAEgDAGg");
	this.shape_19.setTransform(220.7,42.8);

	this.shape_20 = new cjs.Shape();
	this.shape_20.graphics.f("#0066CC").s().p("AAfBcIAAhIQAAgKgDgJQgDgHgGgFQgHgFgLAAQgJAAgJAGQgIAHgDAJIgBAEIAAAGIAABMIgYAAIAAi3IAYAAIAABOIAAAAQADgFAEgEQAEgEAGgDIALgFQAEgBAGAAQAHAAAIACQAHACAHAGQAGAGAFALQAFAJgBAQIAABLg");
	this.shape_20.setTransform(206.8,44);

	this.shape_21 = new cjs.Shape();
	this.shape_21.graphics.f("#0066CC").s().p("AACBQQgGgDgEgEQgFgFgCgJQgCgIAAgLIAAhEIgTAAIAAgRIATAAIAAgeIAVgGIAAAkIAhAAIAAARIghAAIAABDQAAAMAFAGQAEAHAIAAIAIgBIAGgBIABARIgIACIgMABQgIAAgGgCg");
	this.shape_21.setTransform(195.2,45.2);

	this.shape_22 = new cjs.Shape();
	this.shape_22.graphics.f("#0066CC").s().p("AgcBYQgLgCgIgFIAGgRQAGADAKADQAJAEAMAAQALAAAJgFQAJgFAFgJQAFgKAAgPIAAgPIAAAAQgGAJgKAHQgKAFgNABQgQgBgMgHQgMgJgHgOQgHgMAAgSQAAgVAIgPQAIgPANgIQANgHAPgBQAKAAAHAEQAIADAFAFQAFAFADAFIABAAIABgTIAUAAIgBAPIAAAUIAABIQAAAWgFAOQgEANgJAIQgKAJgMADQgMAEgLAAQgMAAgLgEgAgYg8QgKANgBAWQAAAMAEAKQAFAKAIAGQAIAGALAAQALAAAJgGQAIgGAEgLIACgGIAAgFIAAgXIAAgFIgBgGQgDgJgJgIQgIgGgMgBQgQAAgKANg");
	this.shape_22.setTransform(177.8,49.5);

	this.shape_23 = new cjs.Shape();
	this.shape_23.graphics.f("#0066CC").s().p("AAfBAIAAhHQAAgKgDgJQgDgIgGgFQgGgFgLAAQgLAAgHAHQgJAGgCAKIgBAFIgBAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIABAVIABAAQADgGAGgFQAGgFAIgEQAIgDAKAAQAGAAAIACQAIACAGAGQAHAGAEALQAFAKAAAQIAABKg");
	this.shape_23.setTransform(163.7,46.8);

	this.shape_24 = new cjs.Shape();
	this.shape_24.graphics.f("#0066CC").s().p("AgfBUQgNgIgIgPQgJgPAAgUQAAgUAJgPQAIgOAOgIQAOgIAQAAQATAAAOAIQANAJAIANQAHAOABATQgBAYgJAOQgJAPgPAIQgOAGgOAAQgRAAgOgHgAgVgOQgJAGgEALQgDAKAAANQAAAOAEALQAGALAIAGQAJAGAKAAQALAAAIgGQAJgGAFgLQAFgMAAgOQAAgLgEgKQgDgKgJgIQgJgHgNgBQgMAAgJAIgAAPg2IgPgYIAAAAIgPAYIgRAAIAZglIAPAAIAZAlg");
	this.shape_24.setTransform(149.4,44.4);

	this.shape_25 = new cjs.Shape();
	this.shape_25.graphics.f("#0066CC").s().p("AAfBcIAAhIQAAgKgDgJQgDgHgGgFQgHgFgKAAQgLAAgHAGQgJAHgDAJIgCAEIAAAGIAABMIgWAAIAAi3IAWAAIAABOIABAAQADgFAEgEQAEgEAFgDIALgFQAFgBAHAAQAGAAAHACQAIACAHAGQAHAGAEALQAFAJgBAQIAABLg");
	this.shape_25.setTransform(135,44);

	this.shape_26 = new cjs.Shape();
	this.shape_26.graphics.f("#0066CC").s().p("AAZBcIgqg8IgMANIAAAvIgXAAIAAi3IAXAAIAABzIAAAAIAGgHIAGgHIAkgrIAbAAIgwAzIA3BKg");
	this.shape_26.setTransform(122.3,44);

	this.shape_27 = new cjs.Shape();
	this.shape_27.graphics.f("#0066CC").s().p("AgaBRQgNgIgIgOQgHgPAAgTQgBgSAIgOQAGgQAOgJQANgJARAAQAQAAAKAGQAKAFAGAKQAFAJADAKQADAJgBAJIAAAGIgBAFIhXAAQABAPAFAJQAHALAJAEQAJAFALgBQANAAAHgCIAPgEIAEARIgQAEQgLADgPAAQgSAAgOgIgAAiAMQgBgIgCgIQgDgIgHgHQgGgFgOAAQgKAAgIAFQgHAGgDAJQgEAHgCAJIBDAAIAAAAgAggg8QAAgNAFgGQAFgIAIAAQAFAAADACIAHAEIAGADIAFABQAEAAABgCQACgCAAgHIANAAQAAANgFAHQgEAGgJABIgIgCIgHgEIgHgDIgEgCQgEABgBADQgCADAAAFg");
	this.shape_27.setTransform(103.1,44.6);

	this.shape_28 = new cjs.Shape();
	this.shape_28.graphics.f("#0066CC").s().p("AgYBAQgJgDgHgEIAGgSQAFAEAIADQAIADAJgBQALAAAGgFQAGgFAAgIQAAgIgFgGQgGgFgLgEQgRgGgIgIQgIgJAAgMQAAgKAFgJQAFgHAKgFQAJgFANgBQAKAAAIADQAIACAFADIgGARIgKgFQgHgCgJgBQgJAAgFAGQgGAFAAAGQAAAJAGAEQAGAEALAFQARAGAIAIQAIAJAAAOQAAAQgMALQgMALgWAAQgKAAgJgCg");
	this.shape_28.setTransform(91.4,46.9);

	this.shape_29 = new cjs.Shape();
	this.shape_29.graphics.f("#0066CC").s().p("AgfA6QgOgIgHgPQgJgOAAgUQABgUAIgPQAIgPAOgIQAOgIARAAQASAAANAIQAOAJAIAOQAHAOABAUQgBAWgJAPQgKAPgOAHQgOAHgOAAQgSgBgNgHgAgVgoQgJAHgEALQgDALAAALQAAAOAEALQAFALAJAGQAJAGAKAAQALAAAIgGQAJgGAFgLQAFgLAAgOQAAgKgEgLQgEgLgIgIQgJgHgNgBQgMABgJAHg");
	this.shape_29.setTransform(73.7,46.9);

	this.shape_30 = new cjs.Shape();
	this.shape_30.graphics.f("#0066CC").s().p("AAfBcIAAhIQAAgKgDgJQgDgHgGgFQgHgFgKAAQgKAAgJAGQgIAHgDAJIgCAEIAAAGIAABMIgXAAIAAi3IAXAAIAABOIABAAQADgFAEgEQAEgEAGgDIAKgFQAFgBAGAAQAHAAAHACQAIACAHAGQAHAGAEALQAFAJgBAQIAABLg");
	this.shape_30.setTransform(59.3,44);

	this.shape_31 = new cjs.Shape();
	this.shape_31.graphics.f("#0066CC").s().p("AgTA5QgOgIgIgOQgHgPgBgSQABgTAIgPQAIgPAPgJQAPgIAUgBIATADQAIABAEADIgFASIgKgEQgHgCgJAAQgOAAgJAGQgLAHgFAKQgEALAAANQgBAOAGAKQAGALAKAFQAJAHAMAAQAKAAAGgCIAMgFIAEARIgOAFQgJACgNABQgSAAgOgJg");
	this.shape_31.setTransform(46.4,46.9);

	this.shape_32 = new cjs.Shape();
	this.shape_32.graphics.f("#0066CC").s().p("AgwBXIAAitIBdAAIAAATIhHAAIAAA3IBDAAIAAARIhDAAIAAA/IBLAAIAAATg");
	this.shape_32.setTransform(34.6,44.5);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_32},{t:this.shape_31},{t:this.shape_30},{t:this.shape_29},{t:this.shape_28},{t:this.shape_27},{t:this.shape_26},{t:this.shape_25},{t:this.shape_24},{t:this.shape_23},{t:this.shape_22},{t:this.shape_21},{t:this.shape_20},{t:this.shape_19},{t:this.shape_18},{t:this.shape_17},{t:this.shape_16},{t:this.shape_15},{t:this.shape_14},{t:this.shape_13},{t:this.shape_12},{t:this.shape_11},{t:this.shape_10},{t:this.shape_9},{t:this.shape_8},{t:this.shape_7},{t:this.shape_6},{t:this.shape_5},{t:this.shape_4},{t:this.shape_3},{t:this.shape_2},{t:this.shape_1},{t:this.shape}]}).wait(81));

	// Layer 4
	this.shape_33 = new cjs.Shape();
	this.shape_33.graphics.f("#000000").s().p("AgfA6QgNgIgIgPQgJgOAAgUQAAgUAJgPQAIgPAOgIQAOgIAQAAQATAAAOAIQANAJAIAOQAHAOABAUQgBAWgJAPQgJAPgPAHQgOAHgOAAQgSgBgNgHgAgVgoQgJAHgEALQgDALAAALQAAAOAEALQAGALAIAGQAJAGAKAAQALAAAIgGQAJgGAFgLQAFgLAAgOQAAgKgEgLQgDgLgJgIQgJgHgNgBQgMABgJAHg");
	this.shape_33.setTransform(362.2,88.1);

	this.shape_34 = new cjs.Shape();
	this.shape_34.graphics.f("#000000").s().p("AggA8QgIgFgFgIQgEgIAAgKQAAgWATgLQAUgMAkAAIAAgDQAAgFgCgHQgCgHgGgFQgGgFgMAAQgJAAgJADQgIACgHAEIgFgPQAIgFALgDQAKgDALAAQATAAALAIQAKAHAEAMQAEAMAAANIAAAuIABAQIABAOIgVAAIgBgQIgBAAQgGAHgJAGQgKAFgNABQgMgBgJgFgAABAAQgLACgIAHQgIAGAAAMQAAALAGAFQAGAGAJAAQAMgBAHgGQAIgGADgIIABgEIAAgEIAAgUIgFAAQgKAAgKAAg");
	this.shape_34.setTransform(348.4,88.1);

	this.shape_35 = new cjs.Shape();
	this.shape_35.graphics.f("#000000").s().p("AgKBYIAAh9IAWAAIAAB9gAgJg+QgEgEAAgGQAAgHAEgEQAEgEAFAAQAHAAADAEQAEAEAAAHQAAAGgEAEQgDADgHABQgGgBgDgDg");
	this.shape_35.setTransform(339.4,85.6);

	this.shape_36 = new cjs.Shape();
	this.shape_36.graphics.f("#000000").s().p("AgRBUQgRgFgMgNQgMgLgGgRQgHgRAAgUQAAgZAMgVQALgUAVgLQAWgMAcgBQAPABAMACQALACAGADIgGATIgQgFQgJgDgOAAQgVAAgPAJQgPAIgJAQQgJAQAAAVQAAAWAJAQQAIAPAPAJQAPAIAUAAQALAAAHgBQAIgBAEgCIAAg0IgkAAIAAgRIA6AAIAABSIgWAHQgOADgSAAQgTAAgQgFg");
	this.shape_36.setTransform(327.7,85.7);

	this.shape_37 = new cjs.Shape();
	this.shape_37.graphics.f("#000000").s().p("ABEBAIAAhGQAAgSgHgKQgGgLgOAAQgKABgHAGQgHAFgDAJIgCAFIAAAHIAABMIgVAAIAAhKQAAgPgHgKQgHgJgNgBQgHAAgGAEQgFADgEAFQgEAFgCAGIgBAGIgBAFIAABLIgWAAIAAhbIAAgSIgBgQIAUAAIABAVIABAAQADgGAFgGQAGgFAHgDQAIgDAKAAQANAAAJAHQAIAGAFAMIAAAAIAHgJIAHgIQAGgEAGgCQAHgCAJAAQAJgBAJAFQAKAFAGAMQAHAMAAAVIAABJg");
	this.shape_37.setTransform(303.2,88);

	this.shape_38 = new cjs.Shape();
	this.shape_38.graphics.f("#000000").s().p("AgKBYIAAh9IAWAAIAAB9gAgJg+QgEgEAAgGQAAgHAEgEQAEgEAFAAQAHAAADAEQAEAEAAAHQAAAGgEAEQgDADgHABQgGgBgDgDg");
	this.shape_38.setTransform(289.3,85.6);

	this.shape_39 = new cjs.Shape();
	this.shape_39.graphics.f("#000000").s().p("AAjBYIg5hXIgQATIAABEIgXAAIAAivIAXAAIAABVIAAAAIAHgKIAHgJIA1hCIAcAAIg/BLIBEBkg");
	this.shape_39.setTransform(280.1,85.7);

	this.shape_40 = new cjs.Shape();
	this.shape_40.graphics.f("#000000").s().p("AgIBrQgEgEAAgFQAAgGAEgDQAEgEAEAAQAGAAADAEQAEADAAAGQAAAFgEAEQgDAFgGAAQgFAAgDgFgAgKBAIAAh9IAWAAIAAB9gAgJhWQgEgEAAgGQAAgGAEgFQAEgDAFAAQAHAAADADQAEAFAAAGQAAAGgEAEQgDADgHABQgGgBgDgDg");
	this.shape_40.setTransform(263.4,88);

	this.shape_41 = new cjs.Shape();
	this.shape_41.graphics.f("#000000").s().p("AAfBcIAAhIQAAgKgDgJQgDgHgGgFQgHgFgLAAQgJAAgJAGQgIAHgDAJIgBAEIAAAGIAABMIgYAAIAAi3IAYAAIAABOIAAAAQADgFAEgEQAEgEAGgDIAKgFQAFgBAGAAQAHAAAIACQAHACAHAGQAGAGAFALQAFAJgBAQIAABLg");
	this.shape_41.setTransform(253.2,85.2);

	this.shape_42 = new cjs.Shape();
	this.shape_42.graphics.f("#000000").s().p("AgLBYIAAibIg1AAIAAgUICBAAIAAAUIg1AAIAACbg");
	this.shape_42.setTransform(239.7,85.7);

	this.shape_43 = new cjs.Shape();
	this.shape_43.graphics.f("#000000").s().p("AgcBYQgLgCgIgFIAGgSQAGAFAKACQAJADAMAAQALABAJgFQAJgEAFgKQAFgKAAgPIAAgOIAAAAQgGAIgKAHQgKAFgNAAQgQAAgMgIQgMgHgHgPQgHgNAAgRQAAgVAIgPQAIgPANgIQANgIAPAAQAKAAAHADQAIAEAFAFQAFAFADAFIABAAIABgTIAUAAIgBAPIAAAUIAABIQAAAVgFAOQgEAOgJAJQgKAHgMAEQgMADgLAAQgMAAgLgDgAgYg8QgKANgBAWQAAAMAEALQAFAJAIAGQAIAGALAAQALAAAJgGQAIgGAEgKIACgHIAAgGIAAgWIAAgGIgBgEQgDgLgJgGQgIgIgMAAQgQAAgKANg");
	this.shape_43.setTransform(221.1,90.7);

	this.shape_44 = new cjs.Shape();
	this.shape_44.graphics.f("#000000").s().p("AAfBAIAAhHQAAgKgDgJQgCgIgHgFQgGgFgLAAQgKAAgJAHQgIAGgCAKIgBAFIgBAGIAABKIgXAAIAAhbIAAgSIgBgQIAUAAIABAVIABAAQADgGAGgFQAGgFAIgEQAIgDAJAAQAIAAAHACQAIACAGAGQAHAGAEALQAFAKAAAQIAABKg");
	this.shape_44.setTransform(207,88);

	this.shape_45 = new cjs.Shape();
	this.shape_45.graphics.f("#000000").s().p("AgFBsQgDgEgBgFQABgGADgDQAEgEAFAAQAFAAAEAEQADADAAAGQAAAFgDAEQgEAEgGAAQgEAAgEgEgAggA+QgIgFgFgIQgEgIAAgKQAAgWATgLQAUgMAkAAIAAgDQAAgFgCgHQgCgHgGgFQgGgFgMAAQgJAAgJADQgIACgHAEIgFgPQAIgFALgDQAKgDALAAQATAAALAIQAKAHAEAMQAEAMAAANIAAAuIABAQIABAOIgVAAIgBgQIgBAAQgGAHgJAGQgKAFgNABQgMgBgJgFgAABACQgLACgIAHQgIAGAAAMQAAALAGAFQAGAGAJAAQAMgBAHgGQAIgGADgIIABgEIAAgEIAAgVIgFAAQgKAAgKABgAgOhUQgHgFgEgHQgDgHAAgIIAOAAQABAHAFAFQAEAFAHAAQAHAAAEgCQAEgDACgEIACgIIAOAAQgBAOgIAJQgJAJgPAAQgKAAgHgFg");
	this.shape_45.setTransform(193.1,87.9);

	this.shape_46 = new cjs.Shape();
	this.shape_46.graphics.f("#000000").s().p("AgqBZIgSgBIAAhQIgWAAIAAgSIAWAAIAAhLIAWgDIAagBQAXABASAFQARAGAMAKQAMALAGAQQAGAPABAWQAAAUgHARQgGASgNAMQgMAMgUAHQgUAGgYAAIgXAAgAgmBGIALABIAMAAQAkAAATgTQATgUAAgjQAAgfgRgTQgSgRgjgBIgPABIgMABIAAA7IAuAAIAAASIguAAg");
	this.shape_46.setTransform(178,85.7);

	this.shape_47 = new cjs.Shape();
	this.shape_47.graphics.f("#000000").s().p("AgfBTQgOgHgHgPQgJgPABgUQAAgVAIgOQAIgOAOgIQAOgIARAAQASAAANAIQAOAJAIANQAHAOAAAUQAAAWgJAPQgKAQgNAGQgPAIgPgBQgQAAgOgIgAgVgPQgJAIgDAJQgFAMAAAMQABAOAFALQAEAKAJAHQAJAGAKAAQALAAAJgGQAIgHAFgKQAFgLAAgOQAAgMgEgLQgEgJgIgIQgJgIgNAAQgMABgJAGgAAPg2IgPgYIAAAAIgPAYIgRAAIAZgkIAOAAIAZAkg");
	this.shape_47.setTransform(157.2,85.6);

	this.shape_48 = new cjs.Shape();
	this.shape_48.graphics.f("#000000").s().p("AgYBQQgTgKgLgUQgLgUAAgcQAAgbALgUQALgVAVgMQAVgLAaAAQAQAAALADQAKACAFADIgGASQgGgDgKgCQgIgCgMAAQgUAAgPAIQgOAJgJAQQgJAQAAAWQABAVAHAQQAIAQAPAIQAOAJAWAAQAKAAAKgCQAJgCAHgDIAFASQgGADgMADQgMACgQAAQgYAAgUgKg");
	this.shape_48.setTransform(142.8,85.6);

	this.shape_49 = new cjs.Shape();
	this.shape_49.graphics.f("#CCCCCC").s().p("Eg1bAAUIAAgnMBq3AAAIAAAng");
	this.shape_49.setTransform(298.8,114.8);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_49},{t:this.shape_48},{t:this.shape_47},{t:this.shape_46},{t:this.shape_45},{t:this.shape_44},{t:this.shape_43},{t:this.shape_42},{t:this.shape_41},{t:this.shape_40},{t:this.shape_39},{t:this.shape_38},{t:this.shape_37},{t:this.shape_36},{t:this.shape_35},{t:this.shape_34},{t:this.shape_33}]}).wait(81));

	// Layer 5
	this.text = new cjs.Text("* Phần mềm quản lí\n* Các code Entity Framework bên quản lí", "22px 'Myriad Pro'");
	this.text.lineHeight = 28;
	this.text.lineWidth = 271;
	this.text.parent = this;
	this.text.setTransform(-274,255.2);
	this.text._off = true;

	this.timeline.addTween(cjs.Tween.get(this.text).wait(13).to({_off:false},0).wait(1).to({x:-269.5},0).wait(1).to({x:-265},0).wait(1).to({x:-260.4},0).wait(1).to({x:-255.9},0).wait(1).to({x:-251.4},0).wait(1).to({x:-246.9},0).wait(1).to({x:-242.4},0).wait(1).to({x:-237.8},0).wait(1).to({x:-233.3},0).wait(1).to({x:-228.8},0).wait(1).to({x:-224.3},0).wait(1).to({x:-219.8},0).wait(1).to({x:-215.2},0).wait(1).to({x:-210.7},0).wait(1).to({x:-206.2},0).wait(1).to({x:-201.7},0).wait(1).to({x:-197.2},0).wait(1).to({x:-192.7},0).wait(1).to({x:-188.1},0).wait(1).to({x:-183.6},0).wait(1).to({x:-179.1},0).wait(1).to({x:-174.6},0).wait(1).to({x:-170.1},0).wait(1).to({x:-165.5},0).wait(1).to({x:-161},0).wait(1).to({x:-156.5},0).wait(1).to({x:-152},0).wait(1).to({x:-147.5},0).wait(1).to({x:-142.9},0).wait(1).to({x:-138.4},0).wait(1).to({x:-133.9},0).wait(1).to({x:-129.4},0).wait(1).to({x:-124.9},0).wait(1).to({x:-120.3},0).wait(1).to({x:-115.8},0).wait(1).to({x:-111.3},0).wait(1).to({x:-106.8},0).wait(1).to({x:-102.3},0).wait(1).to({x:-97.7},0).wait(1).to({x:-93.2},0).wait(1).to({x:-88.7},0).wait(1).to({x:-84.2},0).wait(1).to({x:-79.7},0).wait(1).to({x:-75.1},0).wait(1).to({x:-70.6},0).wait(1).to({x:-66.1},0).wait(1).to({x:-61.6},0).wait(1).to({x:-57.1},0).wait(1).to({x:-52.5},0).wait(1).to({x:-48},0).wait(1).to({x:-43.5},0).wait(1).to({x:-39},0).wait(1).to({x:-34.5},0).wait(1).to({x:-30},0).wait(1).to({x:-25.4},0).wait(1).to({x:-20.9},0).wait(1).to({x:-16.4},0).wait(1).to({x:-11.9},0).wait(1).to({x:-7.4},0).wait(1).to({x:-2.8},0).wait(1).to({x:1.7},0).wait(1).to({x:6.2},0).wait(1).to({x:10.7},0).wait(1).to({x:15.2},0).wait(1).to({x:19.8},0).wait(1).to({x:24.3},0).wait(1).to({x:28.8},0).wait(1));

	// Layer 3
	this.text_1 = new cjs.Text("Nguyễn Xuân Tuấn", "26px 'Myriad Pro'");
	this.text_1.textAlign = "right";
	this.text_1.lineHeight = 33;
	this.text_1.lineWidth = 209;
	this.text_1.parent = this;
	this.text_1.setTransform(776,277.6);
	this.text_1._off = true;

	this.timeline.addTween(cjs.Tween.get(this.text_1).wait(13).to({_off:false},0).wait(1).to({x:772.4},0).wait(1).to({x:768.9},0).wait(1).to({x:765.3},0).wait(1).to({x:761.8},0).wait(1).to({x:758.2},0).wait(1).to({x:754.7},0).wait(1).to({x:751.1},0).wait(1).to({x:747.5},0).wait(1).to({x:744},0).wait(1).to({x:740.4},0).wait(1).to({x:736.9},0).wait(1).to({x:733.3},0).wait(1).to({x:729.7},0).wait(1).to({x:726.2},0).wait(1).to({x:722.6},0).wait(1).to({x:719.1},0).wait(1).to({x:715.5},0).wait(1).to({x:712},0).wait(1).to({x:708.4},0).wait(1).to({x:704.8},0).wait(1).to({x:701.3},0).wait(1).to({x:697.7},0).wait(1).to({x:694.2},0).wait(1).to({x:690.6},0).wait(1).to({x:687},0).wait(1).to({x:683.5},0).wait(1).to({x:679.9},0).wait(1).to({x:676.4},0).wait(1).to({x:672.8},0).wait(1).to({x:669.3},0).wait(1).to({x:665.7},0).wait(1).to({x:662.1},0).wait(1).to({x:658.6},0).wait(1).to({x:655},0).wait(1).to({x:651.5},0).wait(1).to({x:647.9},0).wait(1).to({x:644.3},0).wait(1).to({x:640.8},0).wait(1).to({x:637.2},0).wait(1).to({x:633.7},0).wait(1).to({x:630.1},0).wait(1).to({x:626.6},0).wait(1).to({x:623},0).wait(1).to({x:619.4},0).wait(1).to({x:615.9},0).wait(1).to({x:612.3},0).wait(1).to({x:608.8},0).wait(1).to({x:605.2},0).wait(1).to({x:601.6},0).wait(1).to({x:598.1},0).wait(1).to({x:594.5},0).wait(1).to({x:591},0).wait(1).to({x:587.4},0).wait(1).to({x:583.9},0).wait(1).to({x:580.3},0).wait(1).to({x:576.7},0).wait(1).to({x:573.2},0).wait(1).to({x:569.6},0).wait(1).to({x:566.1},0).wait(1).to({x:562.5},0).wait(1).to({x:558.9},0).wait(1).to({x:555.4},0).wait(1).to({x:551.8},0).wait(1).to({x:548.3},0).wait(1).to({x:544.7},0).wait(1).to({x:541.2},0).wait(1).to({x:537.6},0).wait(1));

	// Layer 2
	this.instance = new lib.Symbol1();
	this.instance.parent = this;
	this.instance.setTransform(284.2,523.8,1,1,0,0,0,225,50.9);

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({regX:223.2,regY:43.7,x:282.4,y:512.4},0).wait(1).to({y:508.3},0).wait(1).to({y:504.2},0).wait(1).to({y:500.1},0).wait(1).to({x:282.5,y:496},0).wait(1).to({y:491.9},0).wait(1).to({y:487.8},0).wait(1).to({y:483.7},0).wait(1).to({y:479.6},0).wait(1).to({y:475.5},0).wait(1).to({y:471.4},0).wait(1).to({y:467.3},0).wait(1).to({y:463.2},0).wait(1).to({y:459.1},0).wait(1).to({x:282.6,y:455},0).wait(1).to({y:450.9},0).wait(1).to({y:446.8},0).wait(1).to({y:442.7},0).wait(1).to({y:438.6},0).wait(1).to({y:434.5},0).wait(1).to({y:430.4},0).wait(1).to({y:426.2},0).wait(1).to({y:422.1},0).wait(1).to({y:418},0).wait(1).to({x:282.7,y:413.9},0).wait(1).to({y:409.8},0).wait(1).to({y:405.7},0).wait(1).to({y:401.6},0).wait(1).to({y:397.5},0).wait(1).to({y:393.4},0).wait(1).to({y:389.3},0).wait(1).to({y:385.2},0).wait(1).to({y:381.1},0).wait(1).to({y:377},0).wait(1).to({x:282.8,y:372.9},0).wait(1).to({y:368.8},0).wait(1).to({y:364.7},0).wait(1).to({y:360.6},0).wait(1).to({y:356.5},0).wait(1).to({y:352.4},0).wait(1).to({y:348.3},0).wait(1).to({y:344.2},0).wait(1).to({y:340.1},0).wait(1).to({y:335.9},0).wait(1).to({x:282.9,y:331.8},0).wait(1).to({y:327.7},0).wait(1).to({y:323.6},0).wait(1).to({y:319.5},0).wait(1).to({y:315.4},0).wait(1).to({y:311.3},0).wait(1).to({y:307.2},0).wait(1).to({y:303.1},0).wait(1).to({y:299},0).wait(1).to({y:294.9},0).wait(1).to({x:283,y:290.8},0).wait(1).to({y:286.7},0).wait(1).to({y:282.6},0).wait(1).to({y:278.5},0).wait(1).to({y:274.4},0).wait(1).to({y:270.3},0).wait(1).to({y:266.2},0).wait(1).to({y:262.1},0).wait(1).to({y:258},0).wait(1).to({y:253.9},0).wait(1).to({x:283.1,y:249.8},0).wait(1).to({y:245.6},0).wait(1).to({y:241.5},0).wait(1).to({y:237.4},0).wait(1).to({y:233.3},0).wait(1).to({y:229.2},0).wait(1).to({y:225.1},0).wait(1).to({y:221},0).wait(1).to({y:216.9},0).wait(1).to({y:212.8},0).wait(1).to({x:283.2,y:208.7},0).wait(1).to({y:204.6},0).wait(1).to({y:200.5},0).wait(1).to({y:196.4},0).wait(1).to({y:192.3},0).wait(1).to({y:188.2},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(231.8,226.5,684,533.8);
// library properties:
lib.properties = {
	id: 'AD183F836D556E4F8E181C9C0286FB1A',
	width: 550,
	height: 400,
	fps: 50,
	color: "#FFFFFF",
	opacity: 1.00,
	webfonts: {},
	manifest: [],
	preloads: []
};



// bootstrap callback support:

(lib.Stage = function(canvas) {
	createjs.Stage.call(this, canvas);
}).prototype = p = new createjs.Stage();

p.setAutoPlay = function(autoPlay) {
	this.tickEnabled = autoPlay;
}
p.play = function() { this.tickEnabled = true; this.getChildAt(0).gotoAndPlay(this.getTimelinePosition()) }
p.stop = function(ms) { if(ms) this.seek(ms); this.tickEnabled = false; }
p.seek = function(ms) { this.tickEnabled = true; this.getChildAt(0).gotoAndStop(lib.properties.fps * ms / 1000); }
p.getDuration = function() { return this.getChildAt(0).totalFrames / lib.properties.fps * 1000; }

p.getTimelinePosition = function() { return this.getChildAt(0).currentFrame / lib.properties.fps * 1000; }

an.bootcompsLoaded = an.bootcompsLoaded || [];
if(!an.bootstrapListeners) {
	an.bootstrapListeners=[];
}

an.bootstrapCallback=function(fnCallback) {
	an.bootstrapListeners.push(fnCallback);
	if(an.bootcompsLoaded.length > 0) {
		for(var i=0; i<an.bootcompsLoaded.length; ++i) {
			fnCallback(an.bootcompsLoaded[i]);
		}
	}
};

an.compositions = an.compositions || {};
an.compositions['AD183F836D556E4F8E181C9C0286FB1A'] = {
	getStage: function() { return exportRoot.getStage(); },
	getLibrary: function() { return lib; },
	getSpriteSheet: function() { return ss; },
	getImages: function() { return img; }
};

an.compositionLoaded = function(id) {
	an.bootcompsLoaded.push(id);
	for(var j=0; j<an.bootstrapListeners.length; j++) {
		an.bootstrapListeners[j](id);
	}
}

an.getComposition = function(id) {
	return an.compositions[id];
}



})(createjs = createjs||{}, AdobeAn = AdobeAn||{});
var createjs, AdobeAn;