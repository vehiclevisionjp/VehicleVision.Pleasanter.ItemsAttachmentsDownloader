# ドキュメントガイドライン

このドキュメントでは、VehicleVision.Pleasanter.ItemsAttachmentsDownloader
プロジェクトのドキュメント作成規約について説明します。

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

---

## 基本原則

### 言語

- ドキュメントは**日本語**で記述する
- コード内のコメント（XMLドキュメントコメント含む）も日本語

### 対象読者

- プロジェクトの開発者・コントリビューター

---

## ファイル構成

### ディレクトリ構造

```text
docs/
└── contributing/
    └── documentation-guidelines.md
```

### ファイル命名規則

- ケバブケース（`documentation-guidelines.md`）

---

## Markdownスタイル

### 基本ルール

| ルール         | 内容                                        |
| -------------- | ------------------------------------------- |
| 見出し         | ATX形式（`# H1`）を使用                     |
| 見出しレベル   | 1つずつ順番に（H1 → H2 → H3）               |
| リスト         | `-` を使用（`*` は不可）                    |
| コードブロック | バッククォート3つで囲む                     |
| 行の長さ       | 120文字以内（テーブル・コードブロック除外） |
| 絵文字         | 使用しない                                  |
| HTMLタグ       | 原則使用しない（`<br>` のみ許可）           |
| 型名           | バッククォートで囲む（例: `string`）        |

### フォーマッター（Prettier）

```bash
# フォーマット実行
npm run format

# フォーマットチェック（変更なし）
npm run format:check
```

### Linter（markdownlint）

```bash
# Lintチェック
npm run lint:md

# 自動修正
npm run lint:md:fix
```

---

## npmスクリプト

| スクリプト     | 説明                           |
| -------------- | ------------------------------ |
| `lint:md`      | Markdownの構文チェック         |
| `lint:md:fix`  | Markdownのlintエラーを自動修正 |
| `format`       | Prettierでフォーマット         |
| `format:check` | フォーマットのチェック         |

---

## ドキュメント同期

### 更新ルール

| 変更内容                     | 更新が必要なドキュメント                                   |
| ---------------------------- | ---------------------------------------------------------- |
| ガイドラインの追加           | `CONTRIBUTING.md` および `.github/copilot-instructions.md` |
| プロジェクト設定の変更       | `README.md` および `.github/copilot-instructions.md`       |
| セキュリティ脆弱性の報告対応 | `README.md` の謝辞セクション（報告者名を追記）             |
