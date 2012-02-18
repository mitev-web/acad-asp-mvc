﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("HomeworkSubmissionModel", "FK_Topics_Courses", "Courses", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HomeworkSubmission.DAL.Cours), "Topics", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HomeworkSubmission.DAL.Topic), true)]
[assembly: EdmRelationshipAttribute("HomeworkSubmissionModel", "FK_Submissions_Students", "Students", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HomeworkSubmission.DAL.Student), "Submissions", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HomeworkSubmission.DAL.Submission), true)]
[assembly: EdmRelationshipAttribute("HomeworkSubmissionModel", "FK_Submissions_Topics", "Topics", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HomeworkSubmission.DAL.Topic), "Submissions", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HomeworkSubmission.DAL.Submission), true)]
[assembly: EdmRelationshipAttribute("HomeworkSubmissionModel", "StudentsCourses", "Courses", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HomeworkSubmission.DAL.Cours), "Students", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HomeworkSubmission.DAL.Student))]

#endregion

namespace HomeworkSubmission.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HomeworkSubmissionEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HomeworkSubmissionEntities object using the connection string found in the 'HomeworkSubmissionEntities' section of the application configuration file.
        /// </summary>
        public HomeworkSubmissionEntities() : base("name=HomeworkSubmissionEntities", "HomeworkSubmissionEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HomeworkSubmissionEntities object.
        /// </summary>
        public HomeworkSubmissionEntities(string connectionString) : base(connectionString, "HomeworkSubmissionEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HomeworkSubmissionEntities object.
        /// </summary>
        public HomeworkSubmissionEntities(EntityConnection connection) : base(connection, "HomeworkSubmissionEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cours> Courses
        {
            get
            {
                if ((_Courses == null))
                {
                    _Courses = base.CreateObjectSet<Cours>("Courses");
                }
                return _Courses;
            }
        }
        private ObjectSet<Cours> _Courses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Submission> Submissions
        {
            get
            {
                if ((_Submissions == null))
                {
                    _Submissions = base.CreateObjectSet<Submission>("Submissions");
                }
                return _Submissions;
            }
        }
        private ObjectSet<Submission> _Submissions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Topic> Topics
        {
            get
            {
                if ((_Topics == null))
                {
                    _Topics = base.CreateObjectSet<Topic>("Topics");
                }
                return _Topics;
            }
        }
        private ObjectSet<Topic> _Topics;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourses(Cours cours)
        {
            base.AddObject("Courses", cours);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Submissions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSubmissions(Submission submission)
        {
            base.AddObject("Submissions", submission);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Topics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTopics(Topic topic)
        {
            base.AddObject("Topics", topic);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HomeworkSubmissionModel", Name="Cours")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cours : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cours object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static Cours CreateCours(global::System.Int32 id, global::System.String name, global::System.Boolean isActive)
        {
            Cours cours = new Cours();
            cours.ID = id;
            cours.Name = name;
            cours.IsActive = isActive;
            return cours;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "FK_Topics_Courses", "Topics")]
        public EntityCollection<Topic> Topics
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Topic>("HomeworkSubmissionModel.FK_Topics_Courses", "Topics");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Topic>("HomeworkSubmissionModel.FK_Topics_Courses", "Topics", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "StudentsCourses", "Students")]
        public EntityCollection<Student> Students
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Student>("HomeworkSubmissionModel.StudentsCourses", "Students");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Student>("HomeworkSubmissionModel.StudentsCourses", "Students", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HomeworkSubmissionModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        public static Student CreateStudent(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.String email)
        {
            Student student = new Student();
            student.ID = id;
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Email = email;
            return student;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AcademyID
        {
            get
            {
                return _AcademyID;
            }
            set
            {
                OnAcademyIDChanging(value);
                ReportPropertyChanging("AcademyID");
                _AcademyID = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AcademyID");
                OnAcademyIDChanged();
            }
        }
        private global::System.String _AcademyID;
        partial void OnAcademyIDChanging(global::System.String value);
        partial void OnAcademyIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "FK_Submissions_Students", "Submissions")]
        public EntityCollection<Submission> Submissions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Submission>("HomeworkSubmissionModel.FK_Submissions_Students", "Submissions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Submission>("HomeworkSubmissionModel.FK_Submissions_Students", "Submissions", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "StudentsCourses", "Courses")]
        public EntityCollection<Cours> Courses
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Cours>("HomeworkSubmissionModel.StudentsCourses", "Courses");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Cours>("HomeworkSubmissionModel.StudentsCourses", "Courses", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HomeworkSubmissionModel", Name="Submission")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Submission : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Submission object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="studentID">Initial value of the StudentID property.</param>
        /// <param name="topicID">Initial value of the TopicID property.</param>
        /// <param name="uploadDate">Initial value of the UploadDate property.</param>
        /// <param name="mIMEType">Initial value of the MIMEType property.</param>
        public static Submission CreateSubmission(global::System.Int32 id, global::System.Int32 studentID, global::System.Int32 topicID, global::System.DateTime uploadDate, global::System.String mIMEType)
        {
            Submission submission = new Submission();
            submission.ID = id;
            submission.StudentID = studentID;
            submission.TopicID = topicID;
            submission.UploadDate = uploadDate;
            submission.MIMEType = mIMEType;
            return submission;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                OnStudentIDChanging(value);
                ReportPropertyChanging("StudentID");
                _StudentID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StudentID");
                OnStudentIDChanged();
            }
        }
        private global::System.Int32 _StudentID;
        partial void OnStudentIDChanging(global::System.Int32 value);
        partial void OnStudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TopicID
        {
            get
            {
                return _TopicID;
            }
            set
            {
                OnTopicIDChanging(value);
                ReportPropertyChanging("TopicID");
                _TopicID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TopicID");
                OnTopicIDChanged();
            }
        }
        private global::System.Int32 _TopicID;
        partial void OnTopicIDChanging(global::System.Int32 value);
        partial void OnTopicIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime UploadDate
        {
            get
            {
                return _UploadDate;
            }
            set
            {
                OnUploadDateChanging(value);
                ReportPropertyChanging("UploadDate");
                _UploadDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UploadDate");
                OnUploadDateChanged();
            }
        }
        private global::System.DateTime _UploadDate;
        partial void OnUploadDateChanging(global::System.DateTime value);
        partial void OnUploadDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MIMEType
        {
            get
            {
                return _MIMEType;
            }
            set
            {
                OnMIMETypeChanging(value);
                ReportPropertyChanging("MIMEType");
                _MIMEType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MIMEType");
                OnMIMETypeChanged();
            }
        }
        private global::System.String _MIMEType;
        partial void OnMIMETypeChanging(global::System.String value);
        partial void OnMIMETypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] FileData
        {
            get
            {
                return StructuralObject.GetValidValue(_FileData);
            }
            set
            {
                OnFileDataChanging(value);
                ReportPropertyChanging("FileData");
                _FileData = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FileData");
                OnFileDataChanged();
            }
        }
        private global::System.Byte[] _FileData;
        partial void OnFileDataChanging(global::System.Byte[] value);
        partial void OnFileDataChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "FK_Submissions_Students", "Students")]
        public Student Student
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Student>("HomeworkSubmissionModel.FK_Submissions_Students", "Students").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Student>("HomeworkSubmissionModel.FK_Submissions_Students", "Students").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Student> StudentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Student>("HomeworkSubmissionModel.FK_Submissions_Students", "Students");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Student>("HomeworkSubmissionModel.FK_Submissions_Students", "Students", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "FK_Submissions_Topics", "Topics")]
        public Topic Topic
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Topic>("HomeworkSubmissionModel.FK_Submissions_Topics", "Topics").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Topic>("HomeworkSubmissionModel.FK_Submissions_Topics", "Topics").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Topic> TopicReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Topic>("HomeworkSubmissionModel.FK_Submissions_Topics", "Topics");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Topic>("HomeworkSubmissionModel.FK_Submissions_Topics", "Topics", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HomeworkSubmissionModel", Name="Topic")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Topic : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Topic object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="courseID">Initial value of the CourseID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static Topic CreateTopic(global::System.Int32 id, global::System.Int32 courseID, global::System.String name, global::System.Boolean isActive)
        {
            Topic topic = new Topic();
            topic.ID = id;
            topic.CourseID = courseID;
            topic.Name = name;
            topic.IsActive = isActive;
            return topic;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CourseID
        {
            get
            {
                return _CourseID;
            }
            set
            {
                OnCourseIDChanging(value);
                ReportPropertyChanging("CourseID");
                _CourseID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CourseID");
                OnCourseIDChanged();
            }
        }
        private global::System.Int32 _CourseID;
        partial void OnCourseIDChanging(global::System.Int32 value);
        partial void OnCourseIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ActiveFrom
        {
            get
            {
                return _ActiveFrom;
            }
            set
            {
                OnActiveFromChanging(value);
                ReportPropertyChanging("ActiveFrom");
                _ActiveFrom = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ActiveFrom");
                OnActiveFromChanged();
            }
        }
        private Nullable<global::System.DateTime> _ActiveFrom;
        partial void OnActiveFromChanging(Nullable<global::System.DateTime> value);
        partial void OnActiveFromChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ActiveTo
        {
            get
            {
                return _ActiveTo;
            }
            set
            {
                OnActiveToChanging(value);
                ReportPropertyChanging("ActiveTo");
                _ActiveTo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ActiveTo");
                OnActiveToChanged();
            }
        }
        private Nullable<global::System.DateTime> _ActiveTo;
        partial void OnActiveToChanging(Nullable<global::System.DateTime> value);
        partial void OnActiveToChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "FK_Topics_Courses", "Courses")]
        public Cours Cours
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cours>("HomeworkSubmissionModel.FK_Topics_Courses", "Courses").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cours>("HomeworkSubmissionModel.FK_Topics_Courses", "Courses").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Cours> CoursReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cours>("HomeworkSubmissionModel.FK_Topics_Courses", "Courses");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Cours>("HomeworkSubmissionModel.FK_Topics_Courses", "Courses", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeworkSubmissionModel", "FK_Submissions_Topics", "Submissions")]
        public EntityCollection<Submission> Submissions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Submission>("HomeworkSubmissionModel.FK_Submissions_Topics", "Submissions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Submission>("HomeworkSubmissionModel.FK_Submissions_Topics", "Submissions", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}