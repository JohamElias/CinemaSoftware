﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaSoftLP2.ServiceWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", ConfigurationName="ServiceWS.ServiceWS")]
    public interface ServiceWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarPeliculasPorTituloRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarPeliculasPorTituloResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloResponse ListarPeliculasPorTitulo(CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarPeliculasPorTituloRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarPeliculasPorTituloResponse" +
            "")]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloResponse> ListarPeliculasPorTituloAsync(CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/helloRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CinemaSoftLP2.ServiceWS.helloResponse hello(CinemaSoftLP2.ServiceWS.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/helloRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/helloResponse")]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.helloResponse> helloAsync(CinemaSoftLP2.ServiceWS.helloRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarGenerosRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarGenerosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CinemaSoftLP2.ServiceWS.ListarGenerosResponse ListarGeneros(CinemaSoftLP2.ServiceWS.ListarGenerosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarGenerosRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarGenerosResponse")]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarGenerosResponse> ListarGenerosAsync(CinemaSoftLP2.ServiceWS.ListarGenerosRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/GuardarPeliculaRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/GuardarPeliculaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CinemaSoftLP2.ServiceWS.GuardarPeliculaResponse GuardarPelicula(CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/GuardarPeliculaRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/GuardarPeliculaResponse")]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.GuardarPeliculaResponse> GuardarPeliculaAsync(CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarActoresPorNombreRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarActoresPorNombreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CinemaSoftLP2.ServiceWS.ListarActoresPorNombreResponse ListarActoresPorNombre(CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarActoresPorNombreRequest", ReplyAction="http://services.cinemasoft.pucp.edu.pe/ServiceWS/ListarActoresPorNombreResponse")]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarActoresPorNombreResponse> ListarActoresPorNombreAsync(CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/")]
    public partial class pelicula : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private actor[] actoresField;
        
        private bool disponibleDobladaField;
        
        private bool disponibleSubtituladaField;
        
        private string duracionField;
        
        private System.DateTime fechaEstrenoField;
        
        private bool fechaEstrenoFieldSpecified;
        
        private genero generoField;
        
        private int idPeliculaField;
        
        private byte[] portadaField;
        
        private string sinopsisField;
        
        private string tituloField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actores", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public actor[] actores {
            get {
                return this.actoresField;
            }
            set {
                this.actoresField = value;
                this.RaisePropertyChanged("actores");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool disponibleDoblada {
            get {
                return this.disponibleDobladaField;
            }
            set {
                this.disponibleDobladaField = value;
                this.RaisePropertyChanged("disponibleDoblada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool disponibleSubtitulada {
            get {
                return this.disponibleSubtituladaField;
            }
            set {
                this.disponibleSubtituladaField = value;
                this.RaisePropertyChanged("disponibleSubtitulada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string duracion {
            get {
                return this.duracionField;
            }
            set {
                this.duracionField = value;
                this.RaisePropertyChanged("duracion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime fechaEstreno {
            get {
                return this.fechaEstrenoField;
            }
            set {
                this.fechaEstrenoField = value;
                this.RaisePropertyChanged("fechaEstreno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaEstrenoSpecified {
            get {
                return this.fechaEstrenoFieldSpecified;
            }
            set {
                this.fechaEstrenoFieldSpecified = value;
                this.RaisePropertyChanged("fechaEstrenoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public genero genero {
            get {
                return this.generoField;
            }
            set {
                this.generoField = value;
                this.RaisePropertyChanged("genero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int idPelicula {
            get {
                return this.idPeliculaField;
            }
            set {
                this.idPeliculaField = value;
                this.RaisePropertyChanged("idPelicula");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=8)]
        public byte[] portada {
            get {
                return this.portadaField;
            }
            set {
                this.portadaField = value;
                this.RaisePropertyChanged("portada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string sinopsis {
            get {
                return this.sinopsisField;
            }
            set {
                this.sinopsisField = value;
                this.RaisePropertyChanged("sinopsis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string titulo {
            get {
                return this.tituloField;
            }
            set {
                this.tituloField = value;
                this.RaisePropertyChanged("titulo");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/")]
    public partial class actor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string apellidoPaternoField;
        
        private int idActorField;
        
        private string nacionalidadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string apellidoPaterno {
            get {
                return this.apellidoPaternoField;
            }
            set {
                this.apellidoPaternoField = value;
                this.RaisePropertyChanged("apellidoPaterno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idActor {
            get {
                return this.idActorField;
            }
            set {
                this.idActorField = value;
                this.RaisePropertyChanged("idActor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nacionalidad {
            get {
                return this.nacionalidadField;
            }
            set {
                this.nacionalidadField = value;
                this.RaisePropertyChanged("nacionalidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/")]
    public partial class genero : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int idGeneroField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int idGenero {
            get {
                return this.idGeneroField;
            }
            set {
                this.idGeneroField = value;
                this.RaisePropertyChanged("idGenero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarPeliculasPorTitulo", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class ListarPeliculasPorTituloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        public ListarPeliculasPorTituloRequest() {
        }
        
        public ListarPeliculasPorTituloRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarPeliculasPorTituloResponse", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class ListarPeliculasPorTituloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CinemaSoftLP2.ServiceWS.pelicula[] @return;
        
        public ListarPeliculasPorTituloResponse() {
        }
        
        public ListarPeliculasPorTituloResponse(CinemaSoftLP2.ServiceWS.pelicula[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name;
        
        public helloRequest() {
        }
        
        public helloRequest(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse() {
        }
        
        public helloResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarGeneros", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class ListarGenerosRequest {
        
        public ListarGenerosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarGenerosResponse", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class ListarGenerosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CinemaSoftLP2.ServiceWS.genero[] @return;
        
        public ListarGenerosResponse() {
        }
        
        public ListarGenerosResponse(CinemaSoftLP2.ServiceWS.genero[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GuardarPelicula", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class GuardarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CinemaSoftLP2.ServiceWS.pelicula pelicula;
        
        public GuardarPeliculaRequest() {
        }
        
        public GuardarPeliculaRequest(CinemaSoftLP2.ServiceWS.pelicula pelicula) {
            this.pelicula = pelicula;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GuardarPeliculaResponse", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class GuardarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public GuardarPeliculaResponse() {
        }
        
        public GuardarPeliculaResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarActoresPorNombre", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class ListarActoresPorNombreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        public ListarActoresPorNombreRequest() {
        }
        
        public ListarActoresPorNombreRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarActoresPorNombreResponse", WrapperNamespace="http://services.cinemasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class ListarActoresPorNombreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.cinemasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CinemaSoftLP2.ServiceWS.actor[] @return;
        
        public ListarActoresPorNombreResponse() {
        }
        
        public ListarActoresPorNombreResponse(CinemaSoftLP2.ServiceWS.actor[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceWSChannel : CinemaSoftLP2.ServiceWS.ServiceWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceWSClient : System.ServiceModel.ClientBase<CinemaSoftLP2.ServiceWS.ServiceWS>, CinemaSoftLP2.ServiceWS.ServiceWS {
        
        public ServiceWSClient() {
        }
        
        public ServiceWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloResponse CinemaSoftLP2.ServiceWS.ServiceWS.ListarPeliculasPorTitulo(CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest request) {
            return base.Channel.ListarPeliculasPorTitulo(request);
        }
        
        public CinemaSoftLP2.ServiceWS.pelicula[] ListarPeliculasPorTitulo(string nombre) {
            CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest inValue = new CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest();
            inValue.nombre = nombre;
            CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloResponse retVal = ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).ListarPeliculasPorTitulo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloResponse> CinemaSoftLP2.ServiceWS.ServiceWS.ListarPeliculasPorTituloAsync(CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest request) {
            return base.Channel.ListarPeliculasPorTituloAsync(request);
        }
        
        public System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloResponse> ListarPeliculasPorTituloAsync(string nombre) {
            CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest inValue = new CinemaSoftLP2.ServiceWS.ListarPeliculasPorTituloRequest();
            inValue.nombre = nombre;
            return ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).ListarPeliculasPorTituloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CinemaSoftLP2.ServiceWS.helloResponse CinemaSoftLP2.ServiceWS.ServiceWS.hello(CinemaSoftLP2.ServiceWS.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            CinemaSoftLP2.ServiceWS.helloRequest inValue = new CinemaSoftLP2.ServiceWS.helloRequest();
            inValue.name = name;
            CinemaSoftLP2.ServiceWS.helloResponse retVal = ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.helloResponse> CinemaSoftLP2.ServiceWS.ServiceWS.helloAsync(CinemaSoftLP2.ServiceWS.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.helloResponse> helloAsync(string name) {
            CinemaSoftLP2.ServiceWS.helloRequest inValue = new CinemaSoftLP2.ServiceWS.helloRequest();
            inValue.name = name;
            return ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CinemaSoftLP2.ServiceWS.ListarGenerosResponse CinemaSoftLP2.ServiceWS.ServiceWS.ListarGeneros(CinemaSoftLP2.ServiceWS.ListarGenerosRequest request) {
            return base.Channel.ListarGeneros(request);
        }
        
        public CinemaSoftLP2.ServiceWS.genero[] ListarGeneros() {
            CinemaSoftLP2.ServiceWS.ListarGenerosRequest inValue = new CinemaSoftLP2.ServiceWS.ListarGenerosRequest();
            CinemaSoftLP2.ServiceWS.ListarGenerosResponse retVal = ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).ListarGeneros(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarGenerosResponse> CinemaSoftLP2.ServiceWS.ServiceWS.ListarGenerosAsync(CinemaSoftLP2.ServiceWS.ListarGenerosRequest request) {
            return base.Channel.ListarGenerosAsync(request);
        }
        
        public System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarGenerosResponse> ListarGenerosAsync() {
            CinemaSoftLP2.ServiceWS.ListarGenerosRequest inValue = new CinemaSoftLP2.ServiceWS.ListarGenerosRequest();
            return ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).ListarGenerosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CinemaSoftLP2.ServiceWS.GuardarPeliculaResponse CinemaSoftLP2.ServiceWS.ServiceWS.GuardarPelicula(CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest request) {
            return base.Channel.GuardarPelicula(request);
        }
        
        public int GuardarPelicula(CinemaSoftLP2.ServiceWS.pelicula pelicula) {
            CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest inValue = new CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest();
            inValue.pelicula = pelicula;
            CinemaSoftLP2.ServiceWS.GuardarPeliculaResponse retVal = ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).GuardarPelicula(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.GuardarPeliculaResponse> CinemaSoftLP2.ServiceWS.ServiceWS.GuardarPeliculaAsync(CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest request) {
            return base.Channel.GuardarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.GuardarPeliculaResponse> GuardarPeliculaAsync(CinemaSoftLP2.ServiceWS.pelicula pelicula) {
            CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest inValue = new CinemaSoftLP2.ServiceWS.GuardarPeliculaRequest();
            inValue.pelicula = pelicula;
            return ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).GuardarPeliculaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CinemaSoftLP2.ServiceWS.ListarActoresPorNombreResponse CinemaSoftLP2.ServiceWS.ServiceWS.ListarActoresPorNombre(CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest request) {
            return base.Channel.ListarActoresPorNombre(request);
        }
        
        public CinemaSoftLP2.ServiceWS.actor[] ListarActoresPorNombre(string nombre) {
            CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest inValue = new CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest();
            inValue.nombre = nombre;
            CinemaSoftLP2.ServiceWS.ListarActoresPorNombreResponse retVal = ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).ListarActoresPorNombre(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarActoresPorNombreResponse> CinemaSoftLP2.ServiceWS.ServiceWS.ListarActoresPorNombreAsync(CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest request) {
            return base.Channel.ListarActoresPorNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<CinemaSoftLP2.ServiceWS.ListarActoresPorNombreResponse> ListarActoresPorNombreAsync(string nombre) {
            CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest inValue = new CinemaSoftLP2.ServiceWS.ListarActoresPorNombreRequest();
            inValue.nombre = nombre;
            return ((CinemaSoftLP2.ServiceWS.ServiceWS)(this)).ListarActoresPorNombreAsync(inValue);
        }
    }
}
