import{a as v}from"../../../_chunks/chunk-DAU5T2UB.js";import{e as T,f as D,g as R,h as r,i as u}from"../../../_chunks/chunk-P4E5DEEG.js";import{a as w}from"../../../_chunks/chunk-TAK75ZWJ.js";import{c as e,f as l,g as a,h as c,i as d,j as m}from"../../../_chunks/chunk-7V7WNOD5.js";var B=l(m(),1);var C=l(m(),1),t=l(m(),1);var h=class h extends C.TemplatedDialog{constructor(o){super(o),this.permissions=new v({element:this.byId("Permissions"),showRevoke:!1}),R.List({RoleID:this.options.roleID},n=>{this.permissions.value=n.Entities.map(p=>({PermissionKey:p}))}),this.permissions.implicitPermissions=(0,t.getRemoteData)("Administration.ImplicitPermissions")}getDialogOptions(){let o=super.getDialogOptions();return o.buttons=[{text:(0,t.localText)("Dialogs.OkButton"),click:e(n=>{R.Update({RoleID:this.options.roleID,Permissions:this.permissions.value.map(p=>p.PermissionKey)},p=>{this.dialogClose(),window.setTimeout(()=>(0,t.notifySuccess)((0,t.localText)("Site.RolePermissionDialog.SaveSuccess")),0)})},"click")},{text:(0,t.localText)("Dialogs.CancelButton"),click:e(()=>this.dialogClose(),"click")}],o.title=(0,t.format)((0,t.localText)("Site.RolePermissionDialog.DialogTitle"),this.options.title),o}getTemplate(){return'<div id="~_Permissions"></div>'}};e(h,"RolePermissionDialog");var g=h;var P=l(m(),1);var b="edit-permissions",k,I,E;k=[P.Decorators.registerClass("LMIS.Administration.RoleDialog")];var i=class i extends(E=P.EntityDialog){constructor(){super(...arguments);this.form=new D(this.idPrefix)}getFormKey(){return D.formKey}getIdProperty(){return r.idProperty}getLocalTextPrefix(){return r.localTextPrefix}getNameProperty(){return r.nameProperty}getService(){return u.baseUrl}getToolbarButtons(){let n=super.getToolbarButtons();return n.push({title:w.Site.RolePermissionDialog.EditButton,cssClass:b,icon:"fa-lock text-green",onClick:e(()=>{new g({roleID:this.entity.RoleId,title:this.entity.RoleName}).dialogOpen()},"onClick")}),n}updateInterface(){super.updateInterface(),this.toolbar.findButton(b).toggleClass("disabled",this.isNewOrDeleted())}};I=a(E),i=d(I,0,"RoleDialog",k,i),e(i,"RoleDialog"),c(I,1,i);var f=i;var x=l(m(),1);var O,S,K;O=[x.Decorators.registerClass("LMIS.Administration.RoleGrid")];var s=class s extends(K=x.EntityGrid){getColumnsKey(){return T.columnsKey}getDialogType(){return f}getIdProperty(){return r.idProperty}getLocalTextPrefix(){return r.localTextPrefix}getService(){return u.baseUrl}constructor(o){super(o)}getDefaultSortBy(){return[r.Fields.RoleName]}};S=a(K),s=d(S,0,"RoleGrid",O,s),e(s,"RoleGrid"),c(S,1,s);var y=s;var Z=e(()=>(0,B.gridPageInit)(y),"default");export{Z as default};
//# sourceMappingURL=RolePage.js.map
