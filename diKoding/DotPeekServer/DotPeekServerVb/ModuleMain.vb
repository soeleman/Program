Imports System.Data.Entity

Friend Module ModuleMain

    Friend Sub Main()
        Using ctx = New BlogContext()
#If DEBUG Then
            ctx.Database.Log = Sub(log) Debug.WriteLine(log)
#End If
            Dim blog = New Blog() With { _
                .PostAt = DateTime.Now, _
                .PostBy = "Scully", _
                .Title = "Missing Building" _
            }

            ctx.Blogs.Add(blog)
            ctx.SaveChanges()

            ctx.Blogs _
                .ToListAsync() _
                .Result _
                .ForEach(Sub(b) Console.WriteLine(b))
        End Using
    End Sub

End Module