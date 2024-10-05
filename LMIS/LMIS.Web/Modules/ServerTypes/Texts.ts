import { proxyTexts } from "@serenity-is/corelib";

namespace LMIS.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleName: string;
                export const RolePermissionId: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const RoleName: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace BookManage {

            namespace Author {
                export const AuthorId: string;
                export const AuthorImage: string;
                export const AuthorName: string;
                export const CreateTime: string;
                export const Email: string;
                export const Sex: string;
                export const UpdateTime: string;
            }

            namespace Book {
                export const AuthorId: string;
                export const AuthorName: string;
                export const BookId: string;
                export const BookImage: string;
                export const BookName: string;
                export const BookStatus: string;
                export const BorrowableInventory: string;
                export const CN: string;
                export const CreateTime: string;
                export const ISBN: string;
                export const ISSN: string;
                export const Inventory: string;
                export const Page: string;
                export const Price: string;
                export const PublisheDate: string;
                export const PublisherId: string;
                export const PublisherName: string;
                export const UpdateTime: string;
            }

            namespace Bookshelf {
                export const BookCapacity: string;
                export const BookCount: string;
                export const BookshelfId: string;
                export const BookshelfImage: string;
                export const CategoryId: string;
                export const CategoryName: string;
                export const CreateTime: string;
                export const Location: string;
                export const UpdateTime: string;
            }

            namespace Category {
                export const CategoryId: string;
                export const CategoryName: string;
                export const CreateTime: string;
                export const UpdateTime: string;
            }

            namespace Publisher {
                export const Contact: string;
                export const ContactPhone: string;
                export const CreateTime: string;
                export const Email: string;
                export const PublisherId: string;
                export const PublisherName: string;
                export const UpdateTime: string;
            }
        }

        namespace InventoryManage {

            namespace BookStore {
                export const BookId: string;
                export const BookName: string;
                export const BookStoreId: string;
                export const BookshelfId: string;
                export const BookshelfLocation: string;
                export const CreateTime: string;
                export const Inventory: string;
                export const UpdateTime: string;
            }

            namespace DownBookshelf {
                export const BookId: string;
                export const BookName: string;
                export const BookshelfId: string;
                export const BookshelfLocation: string;
                export const CreateTime: string;
                export const DownBookshelfId: string;
                export const Inventory: string;
                export const OperateUserId: string;
                export const OperateUserName: string;
                export const Remark: string;
                export const UpdateTime: string;
            }

            namespace UpBookshelf {
                export const BookId: string;
                export const BookName: string;
                export const BookshelfId: string;
                export const BookshelfLocation: string;
                export const CreateTime: string;
                export const Inventory: string;
                export const OperateUserId: string;
                export const OperateUserName: string;
                export const Remark: string;
                export const UpBookshelfId: string;
                export const UpdateTime: string;
            }
        }

        namespace ReaderManage {

            namespace Borrow {
                export const BookId: string;
                export const BookName: string;
                export const BorrowDate: string;
                export const BorrowId: string;
                export const BorrowNo: string;
                export const BorrowReturnDate: string;
                export const BorrowStatus: string;
                export const CreateTime: string;
                export const UpdateTime: string;
                export const UserId: string;
                export const UserName: string;
            }

            namespace CardLevel {
                export const BorrowBooks: string;
                export const BorrowDays: string;
                export const CardLevelId: string;
                export const CardLevelName: string;
                export const CreateTime: string;
                export const Discount: string;
                export const Fee: string;
                export const Penalty: string;
                export const Rent: string;
                export const UpdateTime: string;
            }

            namespace LibraryCard {
                export const CardLevelName: string;
                export const CreateTime: string;
                export const LevelId: string;
                export const LibraryCardId: string;
                export const LibraryCardNo: string;
                export const Status: string;
                export const UpdateTime: string;
                export const UserId: string;
                export const UserName: string;
            }

            namespace UserBill {
                export const CreateTime: string;
                export const Fee: string;
                export const Remark: string;
                export const Type: string;
                export const UpdateTime: string;
                export const UserBillId: string;
                export const UserId: string;
                export const UserName: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace SendActivation {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const AuthorUniqueError: string;
        export const BookHasNotEnoughInventoryError: string;
        export const BookStoreHasNotEnoughInventory: string;
        export const BookUnborrowableEoor: string;
        export const BookUniqueError: string;
        export const BookshelfUniqueError: string;
        export const BookshlefExceedCapacity: string;
        export const BorrowExpiredError: string;
        export const BorrowNotExpiredError: string;
        export const BorrowOperateIllegalityError: string;
        export const BorrowedCountExceedError: string;
        export const CardLevelUniqueError: string;
        export const CategoryUniqueError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const LibraryCardOperateIllegalityError: string;
        export const LibraryCardUniqueError: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const PublisherUniqueError: string;
        export const SavePrimaryKeyError: string;
        export const UserHasNotLibraryCardError: string;
    }

    LMIS['Texts'] = proxyTexts(Texts, '', {
        Db: {
            Administration: {
                Language: {},
                Role: {},
                RolePermission: {},
                Translation: {},
                User: {},
                UserPermission: {},
                UserRole: {}
            },
            BookManage: {
                Author: {},
                Book: {},
                Bookshelf: {},
                Category: {},
                Publisher: {}
            },
            InventoryManage: {
                BookStore: {},
                DownBookshelf: {},
                UpBookshelf: {}
            },
            ReaderManage: {
                Borrow: {},
                CardLevel: {},
                LibraryCard: {},
                UserBill: {}
            }
        },
        Forms: {
            Membership: {
                Login: {},
                SendActivation: {},
                SignUp: {}
            }
        },
        Navigation: {},
        Site: {
            AccessDenied: {},
            Layout: {},
            RolePermissionDialog: {},
            UserDialog: {},
            UserPermissionDialog: {},
            ValidationError: {}
        },
        Validation: {}
    }) as any;
}

export const Texts = LMIS.Texts;