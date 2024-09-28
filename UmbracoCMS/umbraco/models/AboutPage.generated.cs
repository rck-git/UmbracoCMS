//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>About page</summary>
	[PublishedModel("aboutPage")]
	public partial class AboutPage : PublishedContentModel, IHomePage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "aboutPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AboutPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AboutPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// aboutPageCeoImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutPageCeoImage")]
		public virtual string AboutPageCeoImage => this.Value<string>(_publishedValueFallback, "aboutPageCeoImage");

		///<summary>
		/// aboutPageCeoParagraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutPageCeoParagraph")]
		public virtual string AboutPageCeoParagraph => this.Value<string>(_publishedValueFallback, "aboutPageCeoParagraph");

		///<summary>
		/// aboutPageCeoText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutPageCeoText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutPageCeoText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutPageCeoText");

		///<summary>
		/// expertsSmallTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("expertsSmallTitle")]
		public virtual string ExpertsSmallTitle => this.Value<string>(_publishedValueFallback, "expertsSmallTitle");

		///<summary>
		/// expertsTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("expertsTitle")]
		public virtual string ExpertsTitle => this.Value<string>(_publishedValueFallback, "expertsTitle");

		///<summary>
		/// reviewsImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsImage")]
		public virtual string ReviewsImage => this.Value<string>(_publishedValueFallback, "reviewsImage");

		///<summary>
		/// reviewsText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ReviewsText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "reviewsText");

		///<summary>
		/// aboutParagraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutParagraph")]
		public virtual string AboutParagraph => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetAboutParagraph(this, _publishedValueFallback);

		///<summary>
		/// aboutSmallTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSmallTitle")]
		public virtual string AboutSmallTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetAboutSmallTitle(this, _publishedValueFallback);

		///<summary>
		/// aboutTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutTitle")]
		public virtual string AboutTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetAboutTitle(this, _publishedValueFallback);

		///<summary>
		/// brandsList
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("brandsList")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> BrandsList => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetBrandsList(this, _publishedValueFallback);

		///<summary>
		/// ceoNameParagraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ceoNameParagraph")]
		public virtual string CeoNameParagraph => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCeoNameParagraph(this, _publishedValueFallback);

		///<summary>
		/// ceo quote paragraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ceoQuoteParagraph")]
		public virtual string CeoQuoteParagraph => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCeoQuoteParagraph(this, _publishedValueFallback);

		///<summary>
		/// ceoSignatureImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ceoSignatureImage")]
		public virtual string CeoSignatureImage => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCeoSignatureImage(this, _publishedValueFallback);

		///<summary>
		/// companyAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companyAddress")]
		public virtual string CompanyAddress => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCompanyAddress(this, _publishedValueFallback);

		///<summary>
		/// companyEmailAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companyEmailAddress")]
		public virtual string CompanyEmailAddress => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCompanyEmailAddress(this, _publishedValueFallback);

		///<summary>
		/// company Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companyLogo")]
		public virtual string CompanyLogo => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCompanyLogo(this, _publishedValueFallback);

		///<summary>
		/// companyPhoneNumber
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companyPhoneNumber")]
		public virtual string CompanyPhoneNumber => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetCompanyPhoneNumber(this, _publishedValueFallback);

		///<summary>
		/// contactButton
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactButton")]
		public virtual string ContactButton => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetContactButton(this, _publishedValueFallback);

		///<summary>
		/// footer text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerText")]
		public virtual string FooterText => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetFooterText(this, _publishedValueFallback);

		///<summary>
		/// heroImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroImage")]
		public virtual string HeroImage => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetHeroImage(this, _publishedValueFallback);

		///<summary>
		/// heroParagraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroParagraph")]
		public virtual string HeroParagraph => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetHeroParagraph(this, _publishedValueFallback);

		///<summary>
		/// heroSpan
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroSpan")]
		public virtual string HeroSpan => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetHeroSpan(this, _publishedValueFallback);

		///<summary>
		/// heroTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroTitle")]
		public virtual string HeroTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetHeroTitle(this, _publishedValueFallback);

		///<summary>
		/// heroTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroTitle2")]
		public virtual string HeroTitle2 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetHeroTitle2(this, _publishedValueFallback);

		///<summary>
		/// NavLinks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("navLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> NavLinks => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetNavLinks(this, _publishedValueFallback);

		///<summary>
		/// Page Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageDescription")]
		public virtual string PageDescription => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetPageDescription(this, _publishedValueFallback);

		///<summary>
		/// Page Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> PageKeywords => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetPageKeywords(this, _publishedValueFallback);

		///<summary>
		/// PageTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetPageTitle(this, _publishedValueFallback);

		///<summary>
		/// projectsSectionTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsSectionTitle")]
		public virtual string ProjectsSectionTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetProjectsSectionTitle(this, _publishedValueFallback);

		///<summary>
		/// projectsSmallTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsSmallTitle")]
		public virtual string ProjectsSmallTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetProjectsSmallTitle(this, _publishedValueFallback);

		///<summary>
		/// search
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("search")]
		public virtual string Search => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSearch(this, _publishedValueFallback);

		///<summary>
		/// searchIcon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("searchIcon")]
		public virtual string SearchIcon => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSearchIcon(this, _publishedValueFallback);

		///<summary>
		/// servicesSectionTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesSectionTitle")]
		public virtual string ServicesSectionTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetServicesSectionTitle(this, _publishedValueFallback);

		///<summary>
		/// servicesSmallTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesSmallTitle")]
		public virtual string ServicesSmallTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetServicesSmallTitle(this, _publishedValueFallback);

		///<summary>
		/// Social Media List
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("socialMediaList")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel SocialMediaList => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSocialMediaList(this, _publishedValueFallback);

		///<summary>
		/// socialUrls
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("socialUrls")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> SocialUrls => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSocialUrls(this, _publishedValueFallback);

		///<summary>
		/// SuccessBg
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successBg")]
		public virtual string SuccessBg => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessBg(this, _publishedValueFallback);

		///<summary>
		/// SuccessBg2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successBg2")]
		public virtual string SuccessBg2 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessBg2(this, _publishedValueFallback);

		///<summary>
		/// successButton
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successButton")]
		public virtual string SuccessButton => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessButton(this, _publishedValueFallback);

		///<summary>
		/// SuccessImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successImage")]
		public virtual string SuccessImage => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessImage(this, _publishedValueFallback);

		///<summary>
		/// SuccessImage2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successImage2")]
		public virtual string SuccessImage2 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessImage2(this, _publishedValueFallback);

		///<summary>
		/// successParagraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successParagraph")]
		public virtual string SuccessParagraph => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessParagraph(this, _publishedValueFallback);

		///<summary>
		/// successSectionTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successSectionTitle")]
		public virtual string SuccessSectionTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessSectionTitle(this, _publishedValueFallback);

		///<summary>
		/// successSmallTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successSmallTitle")]
		public virtual string SuccessSmallTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessSmallTitle(this, _publishedValueFallback);

		///<summary>
		/// successStory1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStory1")]
		public virtual string SuccessStory1 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessStory1(this, _publishedValueFallback);

		///<summary>
		/// successStory1Span
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStory1Span")]
		public virtual string SuccessStory1Span => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessStory1Span(this, _publishedValueFallback);

		///<summary>
		/// successStory2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStory2")]
		public virtual string SuccessStory2 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessStory2(this, _publishedValueFallback);

		///<summary>
		/// successStory2Span
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStory2Span")]
		public virtual string SuccessStory2Span => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessStory2Span(this, _publishedValueFallback);

		///<summary>
		/// successStory3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStory3")]
		public virtual string SuccessStory3 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessStory3(this, _publishedValueFallback);

		///<summary>
		/// successStory3Span
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStory3Span")]
		public virtual string SuccessStory3Span => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessStory3Span(this, _publishedValueFallback);

		///<summary>
		/// successSubTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successSubTitle")]
		public virtual string SuccessSubTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessSubTitle(this, _publishedValueFallback);

		///<summary>
		/// successTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successTitle")]
		public virtual string SuccessTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessTitle(this, _publishedValueFallback);

		///<summary>
		/// successTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successTitle2")]
		public virtual string SuccessTitle2 => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetSuccessTitle2(this, _publishedValueFallback);

		///<summary>
		/// urlCredit
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("urlCredit")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> UrlCredit => global::Umbraco.Cms.Web.Common.PublishedModels.HomePage.GetUrlCredit(this, _publishedValueFallback);
	}
}
