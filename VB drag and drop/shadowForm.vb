                For Each Field As FieldInfo In GetType(MetroForm).GetRuntimeFields()
                    If Field.Name = "shadowForm" Then
                        Dim Value As Object = Field.GetValue(Me)
                        For Each Method As MethodInfo In Value.GetType().GetRuntimeMethods()
                            If Method.Name = "PaintShadow" AndAlso Method.IsStatic = False AndAlso Method.GetParameters().Length = 0 Then
                                Method.Invoke(Value, New Object() {})
                                Exit For
                            End If
                        Next
                        Field.SetValue(Me, Value)
                        Exit For
                    End If
                Next