Public Class Electricity
    Private _Voltage As Double
    Private _Current As Double
    Private _Resistance As Double
    Private _Capacitance As Double
    Private _Power As Double
    Private _PermOfAir As Double
    Private _RadiusOfSphere As Double
    Private _EnergyCapacitor As Double
    Private _PotentialDifference As Double
    Private _Wavelength As Double
    Private _Charge As Double
    Private _EFieldIntensity As Double
    Private _MagneticFluxLinkage As Double
    Private _EMF As Double
    Private _Force As Double
    Private _Permitivity As Double
    Private _Resistivity As Double
    Private _WorkDone As Double
    Const PlacksConstant As Double = 6.63E-34
    Const Pi As Double = System.Math.PI

    'calculate power with first equation
    Public Sub CalcPower(ByVal _Current As Double, ByVal _Voltage As Double)
        _Power = _Current * _Voltage
    End Sub
    'return result of power equation
    Public ReadOnly Property Power() As Double
        Get
            Return _Power
        End Get
    End Property
    'calculate power with second equation
    Public Sub CalcPower2(ByVal _Voltage As Double, ByVal _Resistance As Double)
        _Power = (_Voltage ^ 2) / _Resistance
    End Sub
    'return result of power for second equation
    Public ReadOnly Property Power2() As Double
        Get
            Return _Power
        End Get
    End Property
    'calculate power with first equation
    Public Sub CalcPower3(ByVal _Current As Double, ByVal _Resistance As Double)
        _Power = (_Current ^ 2) * _Resistance
    End Sub
    'return result of power equation
    Public ReadOnly Property Power3() As Double
        Get
            Return _Power
        End Get
    End Property
    'calculate voltage
    Public Sub CalcVoltage(ByVal _Current As Double, ByVal _Resistance As Double)
        _Voltage = _Current * _Resistance
    End Sub
    'return result of voltage calculation
    Public ReadOnly Property Voltage() As Double
        Get
            Return _Voltage
        End Get
    End Property
    'calculate current
    Public Sub CalcCurrent(ByVal _Voltage As Double, ByVal _Resistance As Double)
        _Current = _Voltage / _Resistance
    End Sub
    'return value of current calculation
    Public ReadOnly Property Current() As Double
        Get
            Return _Current
        End Get
    End Property
    'calculate resistance
    Public Sub CalcResistance(ByVal _Voltage As Double, ByVal _Current As Double)
        _Resistance = _Voltage / _Current
    End Sub
    'return value of resistance calculation
    Public ReadOnly Property Resistance() As Double
        Get
            Return _Resistance
        End Get
    End Property

    'calculate capacitance
    Public Sub CalcCapacitance(ByVal _Charge As Double, ByVal _PD As Double)
        _Capacitance = _Charge / _PD
    End Sub
    'return value of capacitance calculation
    Public ReadOnly Property Capacitance() As Double
        Get
            Return _Capacitance
        End Get
    End Property
    Public Sub CalcCapacitanceChargedSphere(ByVal _PermOfAir As Double, ByVal _RadiusOfSphere As Double)
        _Capacitance = (4 * Pi * _PermOfAir) * _RadiusOfSphere
    End Sub
    'return value of charge of a capacitor calculation
    Public ReadOnly Property CapacitanceChargedSphere() As Double
        Get
            Return _Capacitance
        End Get
    End Property

    Public Sub calcCapaciCharge(ByVal _PD As Double, ByVal _CapaciFarad As Double)
        _Capacitance = _PD * _CapaciFarad
    End Sub
    'return value of charge of a capacitor calculation
    Public ReadOnly Property CapaciCharge() As Double
        Get
            Return _Capacitance
        End Get
    End Property
    'return value of charge of the energy stored in a capacitor calculation
    Public Sub EnergyStoredInCapacitor(ByVal _PD As Double, ByVal _CapaciFarad As Double)
        _EnergyCapacitor = ((0.5 * _CapaciFarad) * (_PD ^ 2))
    End Sub
    'return value of charge of the energy stored in a capacitor calculation
    Public ReadOnly Property EnergyCapaci() As Double
        Get
            Return _EnergyCapacitor
        End Get
    End Property
    'return value of the pd of a capacitor calculation
    Public Sub CapacitorPD(ByVal _Charge As Double, ByVal _CapaciFarad As Double)
        _PotentialDifference = _Charge / _CapaciFarad
    End Sub
    'return value of charge of the pd of a capacitor calculation
    Public ReadOnly Property PDCapacitor() As Double
        Get
            Return _PotentialDifference
        End Get
    End Property
    'return value of the wavelength calculation
    Public Sub DeBroglie(ByVal _Mass As Double, ByVal _Velocity As Double)
        _Wavelength = PlacksConstant / (_Mass * _Velocity)
    End Sub
    'return value of wavelength calculation
    Public ReadOnly Property DeBroglieResult() As Double
        Get
            Return _Wavelength
        End Get
    End Property
    'return value of electric charge calculation
    Public Sub ElecCharge(ByVal _Current As Double, ByVal _Time As Double)
        _Charge = _Current * _Time
    End Sub
    'value of electric charge calculation
    Public ReadOnly Property ElecChargeResult() As Double
        Get
            Return _Charge
        End Get
    End Property
    ' calculate e-field intensity
    Public Sub EFieldIntensity(ByVal _Charge As Double, ByVal _Distance As Double, ByVal _Permitivity As Double, ByVal _Force As Double)
        _EFieldIntensity = _Charge / (4 * Pi * _Force * (_Distance ^ 2))
    End Sub
    'return value of charge of e-field intensity calculation
    Public ReadOnly Property EFieldIntensityResult() As Double
        Get
            Return _EFieldIntensity
        End Get
    End Property
    'calculate emf in rod 
    Public Sub EMFInRod(ByVal _Flux As Double, ByVal _Distance As Double, ByVal _Length As Double)
        _EMF = _Flux * _Distance * _Length
    End Sub
    'return value of emf in rod calculation
    Public ReadOnly Property EMFInRodResult() As Double
        Get
            Return _EMF
        End Get
    End Property
    'calculate emf in rod 
    Public Sub EFieldIntensity2(ByVal _Force As Double, ByVal _Charge As Double)
        _EFieldIntensity = _Force / _Charge
    End Sub
    'return value of emf in rod calculation
    Public ReadOnly Property EFieldIntensity2Result() As Double
        Get
            Return _EFieldIntensity
        End Get
    End Property
    'calculate electric filed intensity between charged plates
    Public Sub EFieldBetweenPlates(ByVal _Voltage As Double, ByVal _Distance As Double)
        _EFieldIntensity = _Voltage / _Distance
    End Sub
    'return value of electric field intensity between charged plates calculation
    Public ReadOnly Property EFieldBetweenPlatesResult() As Double
        Get
            Return _EFieldIntensity
        End Get
    End Property

    'calculate force on current carrying conductor
    Public Sub FOnCurrentCarryingConductor(ByVal _Flux As Double, ByVal _Current As Double, ByVal _Length As Double)
        _Force = _Flux * _Current * _Length
    End Sub
    'return value of force on current carrying conductor calculation
    Public ReadOnly Property FOnCurrentCarryingConductorResult() As Double
        Get
            Return _Force
        End Get
    End Property

    'calculate force on moving charges
    Public Sub FOnMovingCharges(ByVal _Flux As Double, ByVal _Charge As Double, ByVal _Velocity As Double)
        _Force = _Flux * _Charge * _Velocity
    End Sub
    'return value of force on moving charges calculation
    Public ReadOnly Property FOnMovingChargesResult() As Double
        Get
            Return _Force
        End Get
    End Property
    'calculate force on moving charges
    Public Sub FOnElectronBetweenPlates(ByVal _EFieldIntensity As Double, ByVal _Charge As Double)
        _Force = _EFieldIntensity * _Charge
    End Sub
    'return value of force on moving charges calculation
    Public ReadOnly Property FOnElectronBetweenPlatesResult() As Double
        Get
            Return _Force
        End Get
    End Property
    'calculate magnetic flux linkage
    Public Sub MagneticFluxLinkage(ByVal _FieldStrength As Double, ByVal _Turns As Double, ByVal _Area As Double)
        _MagneticFluxLinkage = _FieldStrength * _Turns * _Area
    End Sub
    'return value of magnetic flux linkage calculation
    Public ReadOnly Property MagneticFluxLinkageResult() As Double
        Get
            Return _MagneticFluxLinkage
        End Get
    End Property
    'calculate permitivity of free space
    Public Sub PermitivityOfFreeSpace(ByVal _FirstCharge As Double, ByVal _SecondCharge As Double, ByVal _Distance As Double, ByVal _Force As Double)
        _Permitivity = ((_FirstCharge * _SecondCharge) / (4 * Pi * _Force * (_Distance ^ 2)))
    End Sub
    'return value of permitivity of free space calculation
    Public ReadOnly Property PermitivityOfFreeSpaceResult() As Double
        Get
            Return _Permitivity
        End Get
    End Property
    'calculate resistivity of a substance
    Public Sub ResistivityOfSubstance(ByVal _Resistance As Double, ByVal _Length As Double, ByVal _Area As Double)
        _Resistivity = (_Resistance * (_Area / _Length))
    End Sub
    'return value of resistivity of a substance calculation
    Public ReadOnly Property ResistivityOfSubstanceResult() As Double
        Get
            Return _Resistivity
        End Get
    End Property
    'calculate resistivity of a substance
    Public Sub WorkDoneOnCharge(ByVal _Charge As Double, ByVal _PD As Double)
        _WorkDone = (_Charge * _PD)
    End Sub
    'return value of resistivity of a substance calculation
    Public ReadOnly Property WorkDoneOnChargeResult() As Double
        Get
            Return _WorkDone
        End Get
    End Property
End Class
