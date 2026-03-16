## VehicleVision.Pleasanter.ItemsAttachmentsDownloader

C#で開発された、Pleasanterインスタンスから添付ファイルを一括ダウンロードするためのツールです。データベースに保存された添付ファイル（BASE64文字列の操作が必要）やローカルに保存された添付ファイル（ファイル名がGUIDでデータベース検索が必要）の両方に対応しています。

サイトIDを指定するだけでサイト単位のダウンロードが可能で、プロセス全体を簡素化します。.NET 10がインストールされたWindows、MacOS、Linuxに対応しており、Pleasanter v1.4.*以降で動作確認済みです。

### 機能

* **サイト単位のダウンロード:** 特定のPleasanterサイトに関連するすべての添付ファイルをダウンロードします。
* **両方の保存形式に対応:** データベースに直接保存された添付ファイル（BASE64）とローカルに保存された添付ファイル（GUIDファイル名）の両方に対応しています。
* **クロスプラットフォーム:** .NET 10がインストールされたWindows、MacOS、Linux環境で動作します。
* **Pleasanter互換性:** Pleasanter v1.4.*以降で動作確認済みです。
* **コマンドラインインターフェース:** シンプルなコマンドライン引数で操作します。
* **整理された出力:** ダウンロードファイルはディレクトリ構造で管理されます。
* **対象フィールドの指定:** ダウンロードに含める添付ファイルフィールドを指定できます。

### 使い方

コマンドラインから実行します。システムに.NET 10がインストールされていることを確認してください。

```bash
dotnet VehicleVision.Pleasanter.ItemsAttachmentsDownloader.dll /Url:{PLEASANTER_URL} /SiteId:{SITE_ID} /ApiKey:{API_KEY} /Path:{OUTPUT_PATH} [/Target:{TARGET_FIELDS}] [/Skip:{SKIP_FIELDS}]
```

#### パラメータ

* /Url:{PLEASANTER_URL}: PleasanterインスタンスのURLです。
* /SiteId:{SITE_ID}: 添付ファイルをダウンロードするPleasanterサイトのIDです。
* /ApiKey:{API_KEY}: 読み取り権限を持つPleasanterのAPIキーです。
* /Path:{OUTPUT_PATH}: ダウンロードした添付ファイルの保存先ローカルディレクトリです。
* /Target:{TARGET_FIELDS}（任意）: ダウンロード対象の添付ファイルフィールドの物理名をカンマ区切りで指定します（例: AttachmentsA,DescriptionA）。
* /Skip:{TARGET_FIELDS}（任意）: ダウンロードをスキップする添付ファイルフィールドの物理名をカンマ区切りで指定します（例: AttachmentsA,DescriptionA）。

#### 実行例

```bash
dotnet VehicleVision.Pleasanter.ItemsAttachmentsDownloader.dll /Url:https://your-pleasanter.com /SiteId:123 /ApiKey:your_secret_api_key /Path:./downloads /Target:AttachmentsA,DescriptionA
```

### ライセンス

このツールは AGPL-3.0 ライセンスの下で公開されています。

### 注意事項

このツールはダウンロードプロセスを簡素化しますが、例外処理は基本的なもののため、エラー発生時に後続の処理が停止する場合があります。
