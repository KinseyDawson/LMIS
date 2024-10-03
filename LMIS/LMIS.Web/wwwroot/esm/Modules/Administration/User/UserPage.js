import{a as k}from"../../../_chunks/chunk-DAU5T2UB.js";import{h as b,k as S,l as C,m as P,n as r,o as y}from"../../../_chunks/chunk-P4E5DEEG.js";import{a as h}from"../../../_chunks/chunk-MCOJBENV.js";import{c as t,f as o,g as c,h as f,i as g,j as n}from"../../../_chunks/chunk-7V7WNOD5.js";var F=o(n(),1);var D=o(n(),1),N=o(n(),1);var B=o(n(),1),s=o(n(),1);var I=class I extends B.TemplatedDialog{constructor(i){super(i),this.permissions=new k({element:this.byId("Permissions"),showRevoke:!0}),P.List({UserID:this.options.userID},e=>{this.permissions.value=e.Entities}),P.ListRolePermissions({UserID:this.options.userID},e=>{this.permissions.rolePermissions=e.Entities}),this.permissions.implicitPermissions=(0,s.getRemoteData)("Administration.ImplicitPermissions"),this.dialogTitle=(0,s.format)((0,s.localText)("Site.UserPermissionDialog.DialogTitle"),this.options.username)}getDialogButtons(){return[{text:(0,s.localText)("Dialogs.OkButton"),cssClass:"btn btn-primary",click:t(i=>{P.Update({UserID:this.options.userID,Permissions:this.permissions.value},e=>{this.dialogClose(),window.setTimeout(()=>(0,s.notifySuccess)((0,s.localText)("Site.UserPermissionDialog.SaveSuccess")),0)})},"click")},{text:(0,s.localText)("Dialogs.CancelButton"),click:t(()=>this.dialogClose(),"click")}]}getTemplate(){return'<div id="~_Permissions"></div>'}};t(I,"UserPermissionDialog");var v=I;var m=o(n(),1),l=o(n(),1);var E,R,A;E=[m.Decorators.registerClass()];var a=class a extends(A=m.EntityDialog){constructor(e){super(e);this.form=new C(this.idPrefix);this.form.Password.change(()=>{m.EditorUtils.setRequired(this.form.PasswordConfirm,this.form.Password.value.length>0)}),this.form.Password.addValidationRule(this.uniqueName,p=>{if(this.form.Password.value.length<6)return(0,l.format)((0,l.localText)(h.Validation.MinRequiredPasswordLength),6)}),this.form.PasswordConfirm.addValidationRule(this.uniqueName,p=>{if(this.form.Password.value!=this.form.PasswordConfirm.value)return(0,l.localText)(h.Validation.PasswordConfirmMismatch)})}getFormKey(){return C.formKey}getIdProperty(){return r.idProperty}getIsActiveProperty(){return r.isActiveProperty}getLocalTextPrefix(){return r.localTextPrefix}getNameProperty(){return r.nameProperty}getService(){return y.baseUrl}getToolbarButtons(){let e=super.getToolbarButtons();return e.push({title:(0,l.localText)(h.Site.UserDialog.EditPermissionsButton),cssClass:"edit-permissions-button",icon:"fa-lock text-green",onClick:t(()=>{new v({userID:this.entity.UserId,username:this.entity.Username}).dialogOpen()},"onClick")}),e}updateInterface(){super.updateInterface(),this.toolbar.findButton("edit-permissions-button").toggleClass("disabled",this.isNewOrDeleted())}afterLoadEntity(){super.afterLoadEntity(),this.form.Password.element.toggleClass("required",this.isNew()).closest(".field").findFirst("sup").toggle(this.isNew()),this.form.PasswordConfirm.element.toggleClass("required",this.isNew()).closest(".field").findFirst("sup").toggle(this.isNew())}};R=c(A),a=g(R,0,"UserDialog",E,a),t(a,"UserDialog"),f(R,1,a);var w=a;var L,U,O;L=[D.Decorators.registerClass()];var d=class d extends(O=D.EntityGrid){getColumnsKey(){return S.columnsKey}getDialogType(){return w}getIdProperty(){return r.idProperty}getIsActiveProperty(){return r.isActiveProperty}getLocalTextPrefix(){return r.localTextPrefix}getService(){return y.baseUrl}constructor(i){super(i)}getDefaultSortBy(){return[r.Fields.Username]}createIncludeDeletedButton(){}getColumns(){var i=super.getColumns(),e=(0,N.tryFirst)(i,u=>u.field==r.Fields.Roles);if(e){var p;b.getLookupAsync().then(u=>{p=u,this.slickGrid.invalidate()}),e.format=u=>{if(!p)return'<i class="fa fa-spinner"></i>';var T=(u.value||[]).map(q=>(p.itemById[q]||{}).RoleName||"");return T.sort(),T.join(", ")}}return i}};U=c(O),d=g(U,0,"UserGrid",L,d),t(d,"UserGrid"),f(U,1,d);var x=d;var re=t(()=>(0,F.gridPageInit)(x),"default");export{re as default};
//# sourceMappingURL=UserPage.js.map
