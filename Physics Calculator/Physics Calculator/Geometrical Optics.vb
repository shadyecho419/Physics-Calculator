Public Class Geometrical_Optics
    Private _AbsRefractiveIndex As Double
    Private _AngularMagnification As Double
    Private _FringeSpacing As Double
    Private _LateralMagnification As Double
    Private _PowerOfLens As Double
    Private _RefIndInMat As Double
    Private _SlitSep As Double
    Private _PhotonEnergy As Double
    Private _FrequencyOfWave As Double
    Private _WaveVelocity As Double
    Private _WaveLength As Double
    Private _WaveIntensity As Double

    Const _PlancksConstant As Double = 6.63E-34


    'calculate absolute refractive index
    Public Sub CalcAbsRefractiveIndex(ByVal _Incident As Double, ByVal _Refracted As Double)
        _AbsRefractiveIndex = System.Math.Sin(_Incident) / System.Math.Sin(_Refracted)
    End Sub
    'return absolute refractive index value
    Public ReadOnly Property AbsRefractiveIndexResult() As Double
        Get
            Return _AbsRefractiveIndex
        End Get
    End Property

    'calculate angular magnification
    Public Sub CalcAngularMagnification(ByVal _LenObjective As Double, ByVal _LenEyePiece As Double)
        _AngularMagnification = _LenObjective / _LenEyePiece
    End Sub
    'return angular magnification value
    Public ReadOnly Property CalcAngularMagnificationResult() As Double
        Get
            Return _AngularMagnification
        End Get
    End Property

    'calculate fringe spacing
    Public Sub CalcFringeSpacing(ByVal _Distance As Double, ByVal _Wavelength As Double, ByVal _SlitSep As Double)
        _FringeSpacing = ((_Wavelength * _Distance) / _SlitSep)
    End Sub
    'return fringe spacing value
    Public ReadOnly Property CalcFringeSpacingResult() As Double
        Get
            Return _FringeSpacing
        End Get
    End Property

    'calculate lateral magnification
    Public Sub CalcLateralMagnification(ByVal _HeightOfImage As Double, ByVal _HeightOfObject As Double)
        _LateralMagnification = (_HeightOfImage / _HeightOfObject)
    End Sub
    'return lateral magnification value
    Public ReadOnly Property CalcLateralMagnificationResult() As Double
        Get
            Return _LateralMagnification
        End Get
    End Property

    'calculate power of a lens
    Public Sub CalcPowerOfLens(ByVal _FocalLengthOfLens As Double)
        _PowerOfLens = (1 / _FocalLengthOfLens)
    End Sub
    'return power of a lens value
    Public ReadOnly Property CalcPowerOfLensResult() As Double
        Get
            Return _PowerOfLens
        End Get
    End Property

    'calculate refractive index of light in material
    Public Sub CalcRefractiveIndexOfLightInMat(ByVal _SpeedOfLight As Double, ByVal _SpeedofLightInMat As Double)
        _RefIndInMat = (_SpeedOfLight / _SpeedofLightInMat)
    End Sub
    'return refractive index of light in material value
    Public ReadOnly Property CalcRefractiveIndexOfLightInMatResult() As Double
        Get
            Return _RefIndInMat
        End Get
    End Property
    'calculate slit seperation
    Public Sub CalcSlitSep(ByVal _DistanceBetweenSlits As Double, ByVal _Wavelength As Double, ByVal _FringeSep As Double)
        _SlitSep = ((_DistanceBetweenSlits * _Wavelength) / _FringeSep)
    End Sub
    'return slit seperation value
    Public ReadOnly Property CalcSlitSepResult() As Double
        Get
            Return _SlitSep
        End Get
    End Property
    'calculate energy of a photon
    Public Sub CalcEnergyOfPhoton(ByVal _Frequency As Double)
        _PhotonEnergy = (_PlancksConstant * _Frequency)
    End Sub
    'return energy of a photon value
    Public ReadOnly Property CalcEnergyOfPhotonResult() As Double
        Get
            Return _PhotonEnergy
        End Get
    End Property
    'calculate frequency of wave
    Public Sub CalcFrequencyOfWave(ByVal _WaveVel As Double, ByVal _WaveLength As Double)
        _FrequencyOfWave = (_WaveVel / _WaveLength)
    End Sub
    'return frequency of wave value
    Public ReadOnly Property CalcFrequencyOfWaveResult() As Double
        Get
            Return _FrequencyOfWave
        End Get
    End Property

    'calculate wave velocity
    Public Sub CalcWaveVelocity(ByVal _Frequency As Double, ByVal _WaveLength As Double)
        _WaveVelocity = (_Frequency * _WaveLength)
    End Sub
    'return wave velocity value
    Public ReadOnly Property CalcWaveVelocityResult() As Double
        Get
            Return _WaveVelocity
        End Get
    End Property

    'calculate wavelength
    Public Sub CalcWaveLength(ByVal _Frequency As Double, ByVal _WaveVel As Double)
        _WaveLength = (_WaveVel / _Frequency)
    End Sub
    'return wavelength value
    Public ReadOnly Property CalcWaveLengthResult() As Double
        Get
            Return _WaveLength
        End Get
    End Property
    'calculate wave intensity
    Public Sub CalcWaveIntensity(ByVal _Power As Double, ByVal _Area As Double)
        _WaveIntensity = (_Power / _Area)
    End Sub
    'return wave intensity value
    Public ReadOnly Property CalcWaveIntensityResult() As Double
        Get
            Return _WaveIntensity
        End Get
    End Property
End Class
