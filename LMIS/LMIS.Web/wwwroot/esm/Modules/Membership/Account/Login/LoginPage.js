import{a as l,c as g,d as o,e as v}from"../../../../_chunks/chunk-HWPRXFD5.js";import{a as m}from"../../../../_chunks/chunk-FI3JWVF5.js";import{c as i,f as h,j as w}from"../../../../_chunks/chunk-7V7WNOD5.js";var e=h(w(),1);function y(n){var c=new d({element:"#LoginPanel"});n!=null&&n.activated&&(c.form.Username.value=n.activated,c.form.Password.element.getNode().focus())}i(y,"pageInit");var s=class s extends e.PropertyPanel{constructor(t){super(t);this.form=new l(this.idPrefix)}getFormKey(){return l.formKey}loginClick(){if(this.validateForm()){var t=this.getSaveEntity();(0,e.serviceCall)({url:(0,e.resolveUrl)("~/Account/Login"),request:t,onSuccess:i(()=>{this.redirectToReturnUrl()},"onSuccess"),onError:i(r=>{var a,u,f;if(((a=r==null?void 0:r.Error)==null?void 0:a.Code)==="RedirectUserTo"){window.location.href=r.Error.Arguments;return}if((f=(u=r==null?void 0:r.Error)==null?void 0:u.Message)!=null&&f.length){(0,e.notifyError)(r.Error.Message),this.form.Password.element.getNode().focus();return}e.ErrorHandling.showServiceError(r.Error)},"onError")})}}getReturnUrl(){var t=(0,e.parseQueryString)();return t.returnUrl||t.ReturnUrl}redirectToReturnUrl(){var t=this.getReturnUrl();if(t&&/^\//.test(t)){var r=window.location.hash;r!=null&&r!="#"&&(t+=r),window.location.href=t}else window.location.href=(0,e.resolveUrl)("~/")}renderContents(){let t=this.useIdPrefix(),r=m.Forms.Membership.Login;this.element.empty().append(o(g,{children:[o(v,{}),o("div",{class:"s-Panel p-4",children:[o("h5",{class:"text-center my-4",children:r.LoginToYourAccount}),o("form",{id:t.Form,action:"",children:[o("div",{id:t.PropertyGrid}),o("div",{class:"px-field",children:o("a",{class:"float-end text-decoration-none",href:(0,e.resolveUrl)("~/Account/ForgotPassword"),children:r.ForgotPassword})}),o("div",{class:"px-field",children:o("button",{id:t.LoginButton,type:"submit",class:"btn btn-primary my-3 w-100",onClick:a=>{a.preventDefault(),this.loginClick()},children:r.SignInButton})})]})]}),o("div",{class:"text-center mt-2",children:o("a",{class:"text-decoration-none",href:(0,e.resolveUrl)("~/Account/SignUp"),children:r.SignUpButton})})]}))}};i(s,"LoginPanel");var d=s;export{y as default};
//# sourceMappingURL=LoginPage.js.map
