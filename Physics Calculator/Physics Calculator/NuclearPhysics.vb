Public Class NuclearPhysics
    Private _Decay As Double
    Private _MassEnRelation As Double
    Private _HalfLife As Double
    Private _NAtEndTime As Double
    Private _NuclearRadius As Double


    'calculate radioactive decay
    Public Sub CalcNuclearDecay(ByVal _DecayConst As Double, ByVal _N As Double)
        _Decay = _DecayConst * _N
    End Sub
    'return radioactive decay value
    Public ReadOnly Property CalcNuclearDecayResult() As Double
        Get
            Return _Decay
        End Get
    End Property

    'calculate Einstein's mass energy relation
    Public Sub CalcMassEnRelation(ByVal _Mass As Double, ByVal _VelLight As Double)
        _MassEnRelation = (_Mass * (_VelLight ^ 2))
    End Sub
    'return Einstein's mass energy relation value
    Public ReadOnly Property CalcMassEnRelationResult() As Double
        Get
            Return _MassEnRelation
        End Get
    End Property

    'calculate halflife of an atom
    Public Sub CalcHalfLife(ByVal _DecayConst As Double)
        _HalfLife = (0.693 / _DecayConst)
    End Sub
    'return halflife of an atom value
    Public ReadOnly Property CalcHalfLifeResult() As Double
        Get
            Return _HalfLife
        End Get
    End Property

    'calculate number of atoms at end time
    Public Sub CalcNAtEndTime(ByVal _NOfAtoms As Double, ByVal _DecayConst As Double, ByVal _ElecCharge As Double, ByVal _Time As Double)
        _NAtEndTime = (_NOfAtoms / ((_ElecCharge ^ (_DecayConst * _Time))))
    End Sub
    'return number of atoms at end time value
    Public ReadOnly Property CalcNAtEndTimeResult() As Double
        Get
            Return _NAtEndTime
        End Get
    End Property

    'calculate nuclear radius
    Public Sub CalcNucleaRad(ByVal _NucleonNumber As Double)
        _NuclearRadius = ((_NucleonNumber ^ 1 / 3) * (0.0000000000000012))
    End Sub
    'return nuclear radius value
    Public ReadOnly Property CalcNucleaRadResult() As Double
        Get
            Return _NuclearRadius
        End Get
    End Property
End Class
