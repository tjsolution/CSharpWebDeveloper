require 'albacore'
require 'fileutils'

namespace :build do

  desc "Builds the solution using the supplied config or Debug buildtools by default"
  msbuild :build, [:config]  do |msb,args|
    args.with_defaults(:config => "Debug")
    msb.properties = { :configuration => args[:config]}
    msb.targets = [:Build ]
    msb.verbosity = :minimal
    msb.parameters = "/maxcpucount"
    msb.solution = "#{SOURCE_ROOT}/#{SOLUTION_NAME}.sln"
  end

  desc "Cleans the solution"
  msbuild :clean do |msb|
    msb.targets = [:Clean]
    msb.solution = "#{SOURCE_ROOT}/#{SOLUTION_NAME}.sln"
  end
end