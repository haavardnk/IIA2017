DELETE TAG
DBCC CHECKIDENT ('[Tag]', RESEED, 0);

DECLARE

@TenvName char(30) = 'Tenv',
@TenvOpcId char(30) = 'Bucket Brigade.Tenv',
@TenvDescription char(30) = 'Enviromental temperature',

@ToutName char(30) = 'Tout',
@ToutOpcId char(30) = 'Bucket Brigade.Tout',
@ToutDescription char(30) = 'Outlet temperature',

@ControlsignalName char(30) = 'Controlsignal',
@ControlsignalOpcId char(30) = 'Bucket Brigade.ControlSignal',
@ControlsignalDescription char(30) = 'Heater controlsignal',

@SetpointName char(30) = 'Setpoint',
@SetpointOpcId char(30) = 'Bucket Brigade.Setpoint',
@SetpointDescription char(30) = 'Controller setpoint'

INSERT INTO TAG (TagName, OpcId, Description) VALUES (@TenvName, @TenvOpcId, @TenvDescription)
INSERT INTO TAG (TagName, OpcId, Description) VALUES (@ToutName, @ToutOpcId, @ToutDescription)
INSERT INTO TAG (TagName, OpcId, Description) VALUES (@ControlsignalName, @ControlsignalOpcId, @ControlsignalDescription)
INSERT INTO TAG (TagName, OpcId, Description) VALUES (@SetpointName, @SetpointOpcId, @SetpointDescription)

