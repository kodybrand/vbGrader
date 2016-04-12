Module Module1

    Friend frmGrid As FormClassGrid
    Friend frmIndividual As FormClassIndividual

    Sub main()
        frmGrid = New FormClassGrid
        frmIndividual = New FormClassIndividual

        'Application.Run(frmIndividual)
        Application.Run(frmGrid)
    End Sub

End Module
