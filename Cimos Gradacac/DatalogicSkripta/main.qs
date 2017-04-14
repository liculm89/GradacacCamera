function onQueryStart()
{
  // TODO
}
function onLaserStop()
{
  // TODO
}
function onLaserStart()
{
  // TODO
}
function onLaserEnd()
{
  // TODO
}
function onLaserError(error)
{
  switch(error)
  {
    case System.DSP_IN_HANG:
      System.resetBoard();
      break;
    case System.DSP_ERROR_INIT:
      // This event is triggered each time the script engine starts
      // if the board was not properly loaded
      MessageBox.critical( "Board initialization error", MessageBox.Ok );
      break;
    // TODO
  }
}
function onClose()
{
  // TODO
}

function toRadians(angle)
{
	return angle = angle * (Math.PI / 180);
}

function coords_updated()
{
	print("Changed");
	var coords_xy = new File(coordsPath + "coords.txt");
	coords_xy.open(File.ReadOnly);
	
	var i = 0;
	while(!coords_xy.eof) {
	
		marking_params[i] = coords_xy.readLine();
		i++;
	}
		
 	print(marking_params[0], marking_params[1], marking_params[2]);
      coords_xy.close();
	laser_doc_generate();
	//System["sigTimer(int)"].connect(checkFolder);
}

function marking_ended()
{
	print("Marking ended... starting new timer...");
	System["sigTimer(int)"].connect(checkFolder);
	
}
function laser_doc_generate()
		
{
	h_doc = new LaserDoc;
	var template = tmplPath;
	h_doc.load(tmplPath);
	
	kut = Math.atan(marking_params[1]/marking_params[0]);
	var alpha = (kut * 180)/ Math.PI;
	
	//double alpha_rad = (alpha * Math.PI) / 180.0;
	
	print(kut + " alpha: " + alpha);
	
	var obj2 = h_doc.getLaserObject("Podloga");
	if(obj2 != null)
	{
		obj2.moveTo(marking_params[0], marking_params[1]);
		obj2.rotate(alpha);
	}
	
	var obj = h_doc.getLaserObject("DMCODE");
	if (obj != null)
	{
		obj.moveTo(marking_params[0], marking_params[1]);
		obj.text = marking_params[2]; 
		obj.rotate(alpha);
	}
	

	 h_doc.sigEndMark.connect( marking_ended );
	h_doc.update();
	
	h_doc.rotate(-90);
	h_doc.update();
	h_doc.execute();
	
	
}

function checkFolder(ID)
{
	if(ID == timer1){
		
		var coords_xy = new File(coordsPath + "coords.txt");
		if(coords_xy.readable)
		{
			print("found");
			System["sigTimer(int)"].disconnect(checkFolder);
			coords_updated();
		}
		
		else
		{
			print("not found");
		}		
	}
}


function main()
{
  System.sigQueryStart.connect(onQueryStart);
  System.sigLaserStop.connect(onLaserStop);
  System.sigLaserStart.connect(onLaserStart);
  System.sigLaserEnd.connect(onLaserEnd);
  System["sigLaserError(int)"].connect(onLaserError);
  System.sigClose.connect(onClose);
  // TODO
  marking_params = [ ];
  tmplPath = "F:\\Cimos Gradacac\\DatalogicSkripta\\datamatrix.xlp";
  coordsPath ="F:\\Cimos Gradacac\\Koordinate\\";
 
  print(coordsPath);
  System["sigTimer(int)"].connect(checkFolder);

  timer1 = System.setTimer(500);
  var paths = ["c:/prova.txt", "C:/Windows/Temp"];
  
}

