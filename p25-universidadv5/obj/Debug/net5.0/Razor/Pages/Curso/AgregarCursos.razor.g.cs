#pragma checksum "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4411a72d9c272a3215d8cab8434e2b00537654"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Curso
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarCursos")]
    public partial class AgregarCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Agregar Curso</h3> \n\n ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                           CrearCurso

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"CursoID\" class=\"control-label\">Curso ID</label>\n                ");
                __Blazor.p21_universidadv1.Pages.Curso.AgregarCursos.TypeInference.CreateInputNumber_0(__builder2, 16, 17, "CursoID", 18, "form-control", 19, 
#nullable restore
#line 17 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                                                            obj.CursoId

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.CursoId = __value, obj.CursoId)), 21, () => obj.CursoId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n              ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label for=\"Titulo\" class=\"control-label\">Titulo</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "Titulo");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                                                         obj.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Titulo = __value, obj.Titulo))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Titulo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"Creditos\" class=\"control-label\">Creditos</label>\n                ");
                __Blazor.p21_universidadv1.Pages.Curso.AgregarCursos.TypeInference.CreateInputNumber_1(__builder2, 36, 37, "Creditos", 38, "form-control", 39, 
#nullable restore
#line 25 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                                                             obj.Creditos

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Creditos = __value, obj.Creditos)), 41, () => obj.Creditos);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label for=\"DepartamentoId\" class=\"control-label\">Departamento </label>\n                ");
                __Blazor.p21_universidadv1.Pages.Curso.AgregarCursos.TypeInference.CreateInputSelect_2(__builder2, 46, 47, "DepartamentoId", 48, "form-control", 49, 
#nullable restore
#line 29 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                                                                   obj.DepartamentoId

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.DepartamentoId = __value, obj.DepartamentoId)), 51, () => obj.DepartamentoId, 52, (__builder3) => {
#nullable restore
#line 30 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                     foreach (var i in @objins )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                        i.DepartamentoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                                           i.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n            \n            ");
                __builder2.AddMarkupContent(57, "<button type=\"submit\" class=\"btn btn-primary\">Guardar</button>\n            ");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "type", "button");
                __builder2.AddAttribute(60, "class", "btn btn-primary");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(62, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/AgregarCursos.razor"
       
    Curso obj = new Curso();
    List<Departamento> objins;
    protected void CrearCurso() {
        serv.Insertar(obj);
        NavigationManager.NavigateTo("Cursos");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("Cursos");
    }
    protected override void OnInitialized() {
         objins = sins.ObtenerTodo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioDepartamentos sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCursos serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p21_universidadv1.Pages.Curso.AgregarCursos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
