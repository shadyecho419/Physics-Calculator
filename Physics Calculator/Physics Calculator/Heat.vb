Public Class Heat
    Private _Boltzman As Double
    Private _CubicExpansitivity As Double
    Private _NumberOfMoles As Double
    Private _IdealPressure As Double
    Private _IdealTemp As Double
    Private _IdealVol As Double
    Private _InternalEnergy As Double
    Private _LinearExpansitivity As Double
    Private _SpecificHeatCapacity As Double
    Private _SpecificLatentHeat As Double
    Const _MolarGasConstant As Double = 8.3

    'calculate boltzman constant
    Public Sub CalcBoltzmanConstant(ByVal _Mass As Double, ByVal _Temperature As Double, ByVal _RMS As Double)
        _Boltzman = ((0.5 * _Mass * _RMS) / (1.5 * _Temperature))
    End Sub
    'return boltzman constant value
    Public ReadOnly Property CalcBoltzmanConstantResult() As Double
        Get
            Return _Boltzman
        End Get
    End Property

    'calculate cubic expansitivity
    Public Sub CalcCubicExpansitivity(ByVal _ChangeInTemp As Double, ByVal _ChangeInVol As Double, ByVal _VolAt273 As Double)
        _CubicExpansitivity = ((_ChangeInVol) / (_ChangeInTemp * _VolAt273))
    End Sub
    'return cubic expansitivity value
    Public ReadOnly Property CalcCubicExpansitivityResult() As Double
        Get
            Return _CubicExpansitivity
        End Get
    End Property

    'calculate Ideal gas number of moles
    Public Sub CalcIdealNumberOfMoles(ByVal _Temp As Double, ByVal _Pressure As Double, ByVal _Volume As Double)
        _NumberOfMoles = ((_Pressure * _Volume) / (_MolarGasConstant * _Temp))
    End Sub
    'return Ideal gas number of moles value
    Public ReadOnly Property CalcIdealNumberOfMolesResult() As Double
        Get
            Return _NumberOfMoles
        End Get
    End Property

    'calculate Ideal pressure
    Public Sub CalcIdealPressure(ByVal _Temp As Double, ByVal _Mols As Double, ByVal _Volume As Double)
        _IdealPressure = ((_Mols * _MolarGasConstant * _Temp) / _Volume)
    End Sub
    'return Ideal pressure value
    Public ReadOnly Property CalcIdealPressureResult() As Double
        Get
            Return _IdealPressure
        End Get
    End Property

    'calculate Ideal temperature
    Public Sub CalcIdealTemp(ByVal _Pressure As Double, ByVal _Mols As Double, ByVal _Volume As Double)
        _IdealTemp = ((_Pressure * _Volume) / (_Mols * _MolarGasConstant))
    End Sub
    'return Ideal temperature value
    Public ReadOnly Property CalcIdealTempResult() As Double
        Get
            Return _IdealTemp
        End Get
    End Property

    'calculate Ideal gas volume
    Public Sub CalcIdealVol(ByVal _Pressure As Double, ByVal _Mols As Double, ByVal _Temperature As Double)
        _IdealVol = ((_Mols * _MolarGasConstant * _Temperature) / _Pressure)
    End Sub
    'return Ideal gas volume value
    Public ReadOnly Property CalcIdealVolResult() As Double
        Get
            Return _IdealVol
        End Get
    End Property

    'calculate monatomic internal energy of gas  
    Public Sub CalcMonatomicIntEnergy(ByVal _GasConstant As Double, ByVal _Temperature As Double)
        _InternalEnergy = ((3 / 2) * _GasConstant * _Temperature)
    End Sub
    'return monatomic internal energy of gas value
    Public ReadOnly Property CalcMonatomicIntEnergyResult() As Double
        Get
            Return _InternalEnergy
        End Get
    End Property

    'calculate diatomic internal energy of gas  
    Public Sub CalcDiatomicIntEnergy(ByVal _GasConstant As Double, ByVal _Temperature As Double)
        _InternalEnergy = ((5 / 2) * _GasConstant * _Temperature)
    End Sub
    'return diatomic internal energy of gas value
    Public ReadOnly Property CalcDiatomicIntEnergyResult() As Double
        Get
            Return _InternalEnergy
        End Get
    End Property

    'calculate linear expansitivity
    Public Sub CalcLinearExp(ByVal _Expansion As Double, ByVal _OriginalLength As Double, ByVal _TemperatureRise As Double)
        _LinearExpansitivity = ((_Expansion) / (_OriginalLength * _TemperatureRise))
    End Sub
    'return linear expansitivity value
    Public ReadOnly Property CalcLinearExpResult() As Double
        Get
            Return _LinearExpansitivity
        End Get
    End Property

    'calculate specific heat capacity
    Public Sub CalcSpecificHeatCap(ByVal _Mass As Double, ByVal _SpecificHeatCap As Double, ByVal _TempChange As Double)
        _SpecificHeatCapacity = _Mass * _SpecificHeatCap * _TempChange
    End Sub
    'return specific heat capacity value
    Public ReadOnly Property CalcSpecificHeatCapResult() As Double
        Get
            Return _SpecificHeatCapacity
        End Get
    End Property

    'calculate specific latent heat of vapourization
    Public Sub CalcSpecificLatentHeat(ByVal _Energy As Double, ByVal _Mass As Double)
        _SpecificLatentHeat = (_Energy / _Mass)
    End Sub
    'return specific latent heat of vapourization value
    Public ReadOnly Property CalcSpecificLatentHeatResult() As Double
        Get
            Return _SpecificLatentHeat
        End Get
    End Property
End Class
