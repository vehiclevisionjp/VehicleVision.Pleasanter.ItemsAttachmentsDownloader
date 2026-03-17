# VehicleVision.Pleasanter.ItemsAttachmentsDownloader

<!-- markdownlint-disable MD013 -->

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/) [![Pleasanter](https://img.shields.io/badge/Pleasanter-1.4.%2A%2B-00A0E9)](https://pleasanter.org/) [![License](https://img.shields.io/badge/License-AGPL--3.0-blue.svg)](LICENSE)

<!-- markdownlint-enable MD013 -->

Pleasanter インスタンスから添付ファイルを一括ダウンロードするためのツールです。
データベースに保存された添付ファイル（BASE64）やローカルに保存された添付ファイル（GUID ファイル名）の両方に対応しています。

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [機能](#機能)
- [使い方](#使い方)
    - [パラメータ](#パラメータ)
    - [実行例](#実行例)
    - [注意事項](#注意事項)
- [プロジェクト構成](#プロジェクト構成)
- [サードパーティライセンス](#サードパーティライセンス)
- [セキュリティ](#セキュリティ)
- [ライセンス](#ライセンス)
- [謝辞](#謝辞)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

## 機能

- **サイト単位のダウンロード:** 特定の Pleasanter サイトに関連するすべての添付ファイルをダウンロード
- **両方の保存形式に対応:** データベース保存（BASE64）とローカル保存（GUID ファイル名）の両方に対応
- **クロスプラットフォーム:** .NET 10 がインストールされた Windows、MacOS、Linux 環境で動作
- **Pleasanter 互換性:** Pleasanter v1.4.\* 以降で動作確認済み
- **コマンドラインインターフェース:** シンプルなコマンドライン引数で操作
- **整理された出力:** ダウンロードファイルはディレクトリ構造で管理
- **対象フィールドの指定:** ダウンロードに含める添付ファイルフィールドを指定可能

## 使い方

コマンドラインから実行します。システムに .NET 10 がインストールされていることを確認してください。

```bash
dotnet VehicleVision.Pleasanter.ItemsAttachmentsDownloader.dll /Url:{PLEASANTER_URL} /SiteId:{SITE_ID} /ApiKey:{API_KEY} /Path:{OUTPUT_PATH} [/Target:{TARGET_FIELDS}] [/Skip:{SKIP_FIELDS}]
```

### パラメータ

| 引数                      | 説明                                                                                 |
| ------------------------- | ------------------------------------------------------------------------------------ |
| `/Url:{PLEASANTER_URL}`   | Pleasanter インスタンスの URL                                                        |
| `/SiteId:{SITE_ID}`       | 添付ファイルをダウンロードする Pleasanter サイトの ID                                |
| `/ApiKey:{API_KEY}`       | 読み取り権限を持つ Pleasanter の API キー                                            |
| `/Path:{OUTPUT_PATH}`     | ダウンロードした添付ファイルの保存先ローカルディレクトリ                             |
| `/Target:{TARGET_FIELDS}` | （任意）ダウンロード対象の添付ファイルフィールドの物理名をカンマ区切りで指定         |
| `/Skip:{SKIP_FIELDS}`     | （任意）ダウンロードをスキップする添付ファイルフィールドの物理名をカンマ区切りで指定 |

### 実行例

```bash
dotnet VehicleVision.Pleasanter.ItemsAttachmentsDownloader.dll \
  /Url:https://your-pleasanter.com \
  /SiteId:123 \
  /ApiKey:your_secret_api_key \
  /Path:./downloads \
  /Target:AttachmentsA,DescriptionA
```

### 注意事項

このツールはダウンロードプロセスを簡素化しますが、例外処理は基本的なもののため、
エラー発生時に後続の処理が停止する場合があります。

## プロジェクト構成

```text
VehicleVision.Pleasanter.ItemsAttachmentsDownloader/
├── .github/                    # GitHub設定（CI/CD、セキュリティポリシー等）
├── .vscode/                    # VS Code設定
├── docs/                       # ドキュメント
│   ├── contributing/           # 開発者向けガイドライン
│   └── wiki/                   # Wikiドキュメント
├── LICENSES/                   # サードパーティライセンス
├── src/
│   └── VehicleVision.Pleasanter.ItemsAttachmentsDownloader/
│       ├── ApiBinaryResponse.cs    # バイナリAPIレスポンスモデル
│       ├── ApiRecordsResponse.cs   # レコードAPIレスポンスモデル
│       ├── ApiSiteResponse.cs      # サイトAPIレスポンスモデル
│       ├── MyArgs.cs               # コマンドライン引数定義
│       ├── Program.cs              # エントリーポイント
│       └── VehicleVision.Pleasanter.ItemsAttachmentsDownloader.csproj
├── .editorconfig
├── .gitignore
├── .markdownlint-cli2.jsonc
├── .prettierignore
├── .prettierrc
├── AUTHORS
├── CONTRIBUTING.md
├── Directory.Build.props
├── LICENSE
├── README.md
├── VehicleVision.Pleasanter.ItemsAttachmentsDownloader.slnx
└── package.json
```

## サードパーティライセンス

このプロジェクトは以下のサードパーティライブラリを使用しています：

| ライブラリ                                                                 | ライセンス | 著作権                        |
| -------------------------------------------------------------------------- | ---------- | ----------------------------- |
| [Microsoft.AspNet.WebApi.Client](https://github.com/aspnet/AspNetWebStack) | Apache-2.0 | Copyright (c) .NET Foundation |
| [PowerArgs](https://github.com/adamabdelhamed/PowerArgs)                   | MIT        | Copyright (c) Adam Abdelhamed |

ライセンスファイルの全文は [LICENSES](./LICENSES/) フォルダを参照してください。

## セキュリティ

セキュリティ上の脆弱性を発見された場合は、[セキュリティポリシー](.github/SECURITY.md)をご確認の上、ご報告ください。

## ライセンス

このプロジェクトは AGPL-3.0 ライセンスの下で公開されています。詳細は [LICENSE](LICENSE) を参照してください。

## 謝辞

セキュリティ脆弱性の報告やプロジェクトへの貢献をしてくださった方々に感謝いたします。

<!-- 貢献者・報告者はこちらに追記 -->
